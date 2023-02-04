public class ListingPromptGenerator
{
    private List<string> _listingPrompts;
        
    public ListingPromptGenerator()
    {
        _listingPrompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
    }

    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(_listingPrompts.Count);
        return _listingPrompts[index];
    }
}