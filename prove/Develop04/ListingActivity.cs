public class ListingActivity : Activity
{
    private ListingPromptGenerator _listingPromptGenerator;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on times in your life " + 
            "when you have shown strength and resilience. This will help you recognize " +
            "the power you have and how you can use it in other aspects of your life.";
        _listingPromptGenerator = new ListingPromptGenerator();
    }

    public void RunActivity()
    {
        Console.WriteLine("Consider the following prompt:\n");
        string prompt = _listingPromptGenerator.GetPrompt();
        Console.WriteLine($" --- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder of each of the following questions " +
            "as they related to this experience");
        Console.Write("You may begin in: ");
        _countdown.Display(5);
        Console.Clear();
    
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
                
        while (DateTime.Now < endTime)
        {
            string question = _listingPromptGenerator.GetPrompt();
            Console.Write($"> {question} ");
            _animation.Display(16);
        }
    }
}
