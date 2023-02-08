using System;

// _____Showing Creativity and Exceeding Requirements_____
// The program stores several different references in a text file.
// Every time a random reference is selected for memorization.
// Scripture verses are also store in a text file.
// Each verse is store on a separate line, but the text for display
// may be formed from several verses (depending on a reference).
// The program keeps track of the hidden words, so each time it
// randomly selects from only those words that are not already hidden.

class Program
{
    static void Main(string[] args)
    {
        string fullReference = "";
        string verseTextFull = "";
        ReferenceGenerator masteryList = new ReferenceGenerator();
        // It could also be created using a file name:
        // ReferenceGenerator masteryList = new ReferenceGenerator("myFilename.txt");
                
        // Get a random reference from the list of references (mastery.txt)
        string[] referenceLine = masteryList.GetReference();

        // Split the reference into parts
        string book = referenceLine[0];
        int chapter = int.Parse(referenceLine[1]);
        int verse = int.Parse(referenceLine[2]);

        // Check if it is a single line or multiple lines
        // and invoke the appropriate constructor
        if (referenceLine.Length == 3) // Single line
        {
            Reference reference = new Reference(book, chapter, verse);
            fullReference = reference.GetFullReference();
            verseTextFull = reference.GetVerseTextFull();
        }
        else // Multiple lines, contains an ending verse
        {
            int verseEnd = int.Parse(referenceLine[3]);  // Extract the ending verse number
            Reference reference = new Reference(book, chapter, verse, verseEnd);
            fullReference = reference.GetFullReference();
            verseTextFull = reference.GetVerseTextFull();
        }

        // Pass the formatted reference and verses to the Scripture class for display
        Scripture scripture = new Scripture(fullReference, verseTextFull);

        // Start the menu loop        
        string input = "";
        while (input != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            // Check if enter is pressed.
            // Then check if all words are hidden.
            // If all words are already hidden, end the program.
            // Otherwise, hide some words and prompt the user again.
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
        }
    }
}