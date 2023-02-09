using System;

// _____Showing Creativity and Exceeding Requirements_____
// To exceed the core requirements I added the ability to track the activation count
// and total duration for each activity while the programm is running.
// I used static attributes to store and update this information and a static method
// DisplayReport() to view the results.
// I also added another menu item ("  4. Display report") that invokes this method.


class Program
{
    static void Main(string[] args)
    {

        int choice = 0;
        while(choice != 5)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Display report");
            Console.WriteLine("  5. Quit");
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

            else if (choice == 4)
            {
                Activity.DisplayReport();
            }
        }
    }
}