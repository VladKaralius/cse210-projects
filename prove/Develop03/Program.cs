using System;

class Program
{
    static void Main(string[] args)
    {
        string fullReference = "";
        string verseTextFull = "";
        ReferenceGenerator masteryList = new ReferenceGenerator();
        string[] referenceLine = masteryList.GetReference();

        string book = referenceLine[0];
        int chapter = int.Parse(referenceLine[1]);
        int verse = int.Parse(referenceLine[2]);

        if (referenceLine.Length == 3)
        {
            Reference reference = new Reference(book, chapter, verse);
            fullReference = reference.GetFullReference();
            verseTextFull = reference.GetVerseTextFull();
        }
        else
        {
            int verseEnd = int.Parse(referenceLine[3]);
            Reference reference = new Reference(book, chapter, verse, verseEnd);
            fullReference = reference.GetFullReference();
            verseTextFull = reference.GetVerseTextFull();
        }

        Scripture scripture = new Scripture(fullReference, verseTextFull);

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