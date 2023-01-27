using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal();

        int choice = 0;
   
        while (choice != 6)
        {
        
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry (get prompt)");
            Console.WriteLine("2. Write a new entry (your own topic)");
            Console.WriteLine("3. Display journal");
            Console.WriteLine("4. Load a text file");
            Console.WriteLine("5. Save a text file");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string currentPrompt = prompt.GetPrompt();
                Console.WriteLine(currentPrompt);
                Console.Write("> ");
                string record = Console.ReadLine();

                Entry entry = new Entry();
                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();
                entry._date = dateText;
                entry._heading = $"Prompt: {currentPrompt}";
                entry._record = record;

                journal._entries.Add(entry);
            }

            if (choice == 2)
            {
                Console.WriteLine("Enter your topic");
                Console.Write("> ");
                string currentTopic = Console.ReadLine();

                Console.WriteLine("Write your text");
                Console.Write("> ");
                string record = Console.ReadLine();

                Entry entry = new Entry();
                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();
                entry._date = dateText;
                entry._heading = $"Topic: {currentTopic}";
                entry._record = record;

                journal._entries.Add(entry);
            }

            else if (choice == 3)
            {
                journal.DisplayEntries();
            }

            else if (choice == 4)
            {
                journal.LoadFile();
            }

            else if (choice == 5)
            {
                journal.SaveFile();
            }

        }
    }
}