using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        CultureInfo enUSCulture = new CultureInfo("en-US");

        List<Activity> activities = new List<Activity>();
       
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
                    DateTime date = DateTime.Now.AddDays(-20);
                    string dateText = date.ToString("dd MMM yyyy", enUSCulture);
                    if (i < 2)
                    {
                        RunningActivity runningActivity =
                        new RunningActivity(dateText, 20, 3.1F);
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