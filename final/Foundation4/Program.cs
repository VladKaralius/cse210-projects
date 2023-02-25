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
                    int length = random.Next(2, 11) * 5;
                    
                    if (i < 2)
                    {
                        float distance = (float)random.Next(6, 12) / 60 * length;

                        RunningActivity runningActivity =
                        new RunningActivity(dateText, length, distance);
                        activities.Add(runningActivity);
                    }

                    else if (i < 4)
                    {
                        float speed = (float)random.Next(100, 301) / 10;
                        
                        CyclingActivity cyclingActivity =
                        new CyclingActivity(dateText, length, speed);
                        activities.Add(cyclingActivity);
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