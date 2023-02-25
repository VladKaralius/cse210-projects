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

            }

            else if (choice == 2)
            {

            }
        }
    }
}