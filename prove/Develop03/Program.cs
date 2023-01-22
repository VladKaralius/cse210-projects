using System;

class Program
{
    static void Main(string[] args)
    {
        string reference = "Proverbs 3:5-6";
        string verse = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
        "In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, verse);

        string input = "";

        do {

            Console.Clear();
            Console.WriteLine(scripture.GetText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            if (input == "")
            {
                if (scripture.GetIsFullyHidden() == false)
                {
                    scripture.HideWords();
                }
                else
                {
                    break;
                }
                
            }

        } while (input != "quit");
    }
}