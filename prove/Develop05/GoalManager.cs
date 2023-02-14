public class GoalManager
{
    private List<Goal> _goals;
    private int _pointTotal;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _pointTotal = 0;
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:\n" +
                          "  1. Simple Goal\n" +
                          "  2. Eternal Goal\n" +
                          "  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Tuple<string, string, int> userInput = GetUserInput();
            string name = userInput.Item1;
            string description = userInput.Item2;
            int basePoints = userInput.Item3;

            SimpleGoal simpleGoal = new SimpleGoal(name, description, basePoints);
            _goals.Add(simpleGoal);
        }

        else if (choice == 2)
        {
            Tuple<string, string, int> userInput = GetUserInput();
            string name = userInput.Item1;
            string description = userInput.Item2;
            int basePoints = userInput.Item3;

            EternalGoal eternalGoal = new EternalGoal(name, description, basePoints);
            _goals.Add(eternalGoal);
        }

        else if (choice == 3)
        {
            Tuple<string, string, int> userInput = GetUserInput();
            string name = userInput.Item1;
            string description = userInput.Item2;
            int basePoints = userInput.Item3;

            // Get unique attributs for the checklist goal
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int timesRequired = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many time? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal
                (name, description, basePoints, bonusPoints, timesRequired);
            _goals.Add(checklistGoal);
        }

        else
        {
            Console.WriteLine("Incorrect choice");
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("\nThe goals are:");
        int lineNumber = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{lineNumber}. {goal.GetInfo()}");
            lineNumber++;
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_pointTotal);
            
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.Serialize());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
       
        _goals.Clear();
       _pointTotal = int.Parse(lines[0]);
        //lines = lines.Skip(1).ToArray();
        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split("~:~");
            string type = parts[0];
            string details = parts[1];
            AddGoal(type, details);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nThe goals are:");
        int lineNumber = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{lineNumber}. {goal.GetName()}");
            lineNumber++;
        }

        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        int pointsReceived = _goals[goalNumber].CompleteGoal();
        _pointTotal += pointsReceived;
        
        if (pointsReceived == 0)
        {
            Console.WriteLine("This goal is already completed. You have earned 0 points.");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {pointsReceived} points!");
        }
        
        Console.WriteLine($"You now have {_pointTotal} points.");
    }

    public int GetPointTotal()
    {
        return _pointTotal;
    }

    // This method deserializes goal details, creates a new goal and adds it to _goals list
    // It is used by LoadGoals() method.
    private void AddGoal(string type, string details)
    {
        string[] parts = details.Split("~|~");

        string name = parts[0];
        string description = parts[1];
        int basePoints = int.Parse(parts[2]);        
                
        if (type == "SimpleGoal")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, basePoints);
            simpleGoal.SetIsComplete(bool.Parse(parts[3]));
            _goals.Add(simpleGoal);
        }

        else if (type == "EternalGoal")
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, basePoints);
            _goals.Add(eternalGoal);
        }

        else if (type == "ChecklistGoal")
        {
            int bonusPoints = int.Parse(parts[3]);
            int timesRequired = int.Parse(parts[4]);
            ChecklistGoal checklistGoal = new ChecklistGoal
                (name, description, basePoints, bonusPoints, timesRequired);
            checklistGoal.SetTimesCompleted(int.Parse(parts[5]));
            _goals.Add(checklistGoal);
        }
    }

    // Prompt for common user input in one place
    private Tuple<string, string, int> GetUserInput()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int basePoints = int.Parse(Console.ReadLine());
        return new Tuple<string, string, int>(name, description, basePoints);
    }
}