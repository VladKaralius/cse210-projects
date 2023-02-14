public class Animation
{
    public Animation()
    {
    }

    public void Display(int duration)
    {
        int cycles = duration;
        
        List<string> symbols = new List<string>{"-", "\\", "|", "/"};

        Console.Write(" ");

        for (int i = 0; i < cycles; i++)
        {
            for (int j = 0; j < symbols.Count(); j++)
            {
                Console.Write($"\b \b{symbols[j]}");
                Thread.Sleep(250);
            }
        }

        Console.Write("\b \b\n");
    }
}
