using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        

        // Animation animation = new Animation();
        // Console.Write("Test ");
        // animation.Display(5);

        Countdown countdown = new Countdown();
        Console.Write("Test ");
        countdown.Display(5);
        Console.WriteLine();

        int choice = 0;
        while(choice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
        }


    }
}