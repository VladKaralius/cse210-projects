public class GoalManager
{


    public GoalManager()
    {

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
            Console.WriteLine(choice);
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
}