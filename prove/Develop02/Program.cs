using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal();

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
                string currentPrompt = prompt.GetPrompt();
                Console.WriteLine(currentPrompt);
                Console.Write("> ");
                string record = Console.ReadLine();

                Entry entry = new Entry();
                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();
                entry._date = dateText;
                entry._prompt = currentPrompt;
                entry._record = record;

                journal._entries.Add(entry);
            }

            else if (choice == 2)
            {
                journal.DisplayEntries();
            }

            else if (choice == 3)
            {
                journal.LoadFile();
            }

            else if (choice == 4)
            {
                journal.SaveFile();
            }

        } while (choice != 5);
    }
}