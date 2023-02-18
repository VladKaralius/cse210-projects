using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        int choice = 0;
        while (choice != 6)
        {
            goalManager.DisplayInfo();

            Console.WriteLine("Menu Options:\n" +
                              "  1. Create New Goal\n" +
                              "  2. List Goals\n" +
                              "  3. Save Goals\n" +
                              "  4. Load Goals\n" +
                              "  5. Record Event\n" +
                              "  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                goalManager.CreateGoal();
            }

            else if (choice == 2)
            {
                goalManager.ListGoals();
            }

            else if (choice == 3)
            {
                goalManager.SaveGoals();
            }

            else if (choice == 4)
            {
                goalManager.LoadGoals();
            }

            else if (choice == 5)
            {
                goalManager.RecordEvent();
            }
        } 
    }
}