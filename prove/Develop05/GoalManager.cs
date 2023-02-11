public class GoalManager
{
    private List<Goal> _goals;

    public GoalManager()
    {
        _goals = new List<Goal>();
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
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int basePoints = int.Parse(Console.ReadLine());

            SimpleGoal simpleGoal = new SimpleGoal(name, description, basePoints);
            _goals.Add(simpleGoal);
        }

        else if (choice == 2)
        {
            Console.WriteLine(choice);
        }

        else if (choice == 3)
        {
            Console.WriteLine(choice);
        }

        else
        {
            Console.WriteLine("Incorrect choice");
        }
    }

    public void ListGoals()
    {
        int lineNumber = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{lineNumber}. {goal.GetInfo()}");
            lineNumber++;
        }
    }
}