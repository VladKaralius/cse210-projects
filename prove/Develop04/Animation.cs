public class Animation
{
    private List<string> _symbols;

    public Animation()
    {
        _symbols = new List<string>{"-", "\\", "|", "/"};
    }

    public void Display(int duration)
    {
        
        Console.Write(" ");

        for (int i = 0; i < duration; i++)
        {
            for (int j = 0; j < _symbols.Count(); j++)
            {
                Console.Write($"\b{_symbols[j]}");
                Thread.Sleep(250);
            }
        }

        Console.Write("\b \n");
    }
}
