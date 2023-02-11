using System;

class Program
{
    static void Main(string[] args)
    {
        
        int choice = 0;
        while (choice != 7)
        {
            Console.WriteLine("\nYou have 0 points.\n");
            Console.WriteLine("Menu Options:\n" +
                              "  1. Create New Goal\n" +
                              "  2. List Goals\n" +
                              "  3. Save Goals\n" +
                              "  4. Load Goals\n" +
                              "  5. Record Event\n" +
                              "  6. Gamify (add later)\n" +
                              "  7. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine(choice);
            }

            else if (choice == 2)
            {
                Console.WriteLine(choice);
            }

            else if (choice == 3)
            {
                Console.WriteLine(choice);
            }

            else if (choice == 4)
            {
                Console.WriteLine(choice);
            }

            else if (choice == 5)
            {
                Console.WriteLine(choice);
            }

            else if (choice == 6)
            {
                Console.WriteLine(choice);
            }
        } 
    }
}