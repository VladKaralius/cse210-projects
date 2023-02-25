using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Random random = new Random();
        
        int choice = 0;
        while (choice != 3)
        {

            Console.WriteLine("Menu Options:\n" +
                              "  1. Create sample activities\n" +
                              "  2. Display activities\n" +
                              "  3. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                activities.Clear();

                for (int i = 0; i < 6; i++)
                {

                    if (i < 2)
                    {
                        RunningActivity runningActivity =
                        new RunningActivity("data", 30, 30);
                        activities.Add(runningActivity);
                    }
                }

                Console.WriteLine("\nActivities created.\n");
            }

            else if (choice == 2)
            {
                Console.WriteLine();

                foreach (Activity activity in activities)
                {
                    Console.WriteLine(activity.GetSummary());
                }

                Console.WriteLine();
            }
        }
    }
}