using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        Random random = new Random();
        string entry = "";

        int choice = 0;
        do {
        
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Load a text file");
            Console.WriteLine("4. Save a text file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                int index = random.Next(prompts.Count);
                Console.WriteLine(prompts[index]);
                Console.Write("> ");
                entry = Console.ReadLine();

            }

        } while (choice != 5);
    }
}