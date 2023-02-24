using System;

// Polymorphism could be used in this assignement, but we have not learned it yet.
// I suppose it is intended that we focus solely on inheritance here.

/* _Showing Creativity and Exceeding Requirements_
To exceed the core requirements I added the ability to track the activation count
and total duration for each activity while the programm is running.
I used static attributes to store and update this information and a static method
DisplayReport() to view the results.
I also added another menu item ("  4. Display report") that invokes this method. */

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while(choice != 5)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n" +
                              "  1. Start breathing activity\n" +
                              "  2. Start reflecting activity\n" +
                              "  3. Start listing activity\n +" +
                              "  4. Display report\n" +
                              "  5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.RunStartingSequence();
                breathingActivity.RunActivity();
                breathingActivity.RunEndingSequence();
            }

            else if (choice == 2)
            {
                Console.Clear();
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.RunStartingSequence();
                reflectionActivity.RunActivity();
                reflectionActivity.RunEndingSequence();                
            }

            else if (choice == 3)
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.RunStartingSequence();
                listingActivity.RunActivity();
                listingActivity.RunEndingSequence();                
            }

            else if (choice == 4)
            {
                Activity.DisplayReport();
            }
        }
    }
}