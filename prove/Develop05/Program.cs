using System;

/* _Showing Creativity and Exceeding Requirements_
To exceed the core requirements I added the leveling system.
First level requires 100 points, second - 200, third - 300,
and so on, each increasing by 100. A message is displayed
when a new level is reached.
The current level and points needed to reach the next level are
displayed below the total points using a different color.
Also, I added a progress bar that shows your progress to the
next level. */

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