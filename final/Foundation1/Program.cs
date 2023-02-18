using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine("Menu Options:\n" +
                              "  1. Generate sample data\n" +
                              "  2. List Goals\n" +
                              "  3. Save Goals\n" +
                              "  4. Load Goals\n" +
                              "  5. Record Event\n" +
                              "  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                SampleDataGenerator sample = new SampleDataGenerator();
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine(sample.GetNextTitle());
                }
            }

            else if (choice == 2)
            {

            }

            else if (choice == 3)
            {
   
            }

            else if (choice == 4)
            {

            }

            else if (choice == 5)
            {

            }
        }
    }
}