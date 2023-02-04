using System;

class Program
{
    static void Main(string[] args)
    {

        int choice = 0;
        while(choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.RunActivity();
                breathingActivity.DisplayEndingMessage();
            }

            else if (choice == 2)
            {
                Console.Clear();
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.DisplayStartingMessage();
                reflectionActivity.RunActivity();
                reflectionActivity.DisplayEndingMessage();                
            }

            else if (choice == 3)
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayStartingMessage();
                listingActivity.RunActivity();
                listingActivity.DisplayEndingMessage();                
            }
        }
    }
}