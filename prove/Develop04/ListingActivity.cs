public class ListingActivity : Activity
{
    private ListingPromptGenerator _listingPromptGenerator;
    private int _itemCount;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life " + 
            "by having you list as many things as you can in a certain area.";
        _listingPromptGenerator = new ListingPromptGenerator();
        _itemCount = 0;
        // Keep track of activations.
        _activationCount[_name]++;
    }

    public void RunActivity()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        string prompt = _listingPromptGenerator.GetPrompt();
        Console.WriteLine($" --- {prompt} ---");
        Console.Write("\nYou may begin in: ");
        _countdown.Display(5);
    
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
                
        while (DateTime.Now < endTime)
        {
            Console.Write($"> ");
            Console.ReadLine();
            _itemCount++;
        }

        Console.WriteLine($"You listed {_itemCount} items!");
    }
}
