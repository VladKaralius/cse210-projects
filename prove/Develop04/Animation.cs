public class Animation
{
    public Animation()
    {
    }

    public void Display(int duration)
    {
        
        List<string> symbols = new List<string>{"-", "\\", "|", "/"};

        Console.Write(" ");

        for (int i = 0; i < duration; i++)
        {
            for (int j = 0; j < symbols.Count(); j++)
            {
                Console.Write($"\b{symbols[j]}");
                Thread.Sleep(250);
            }
        }

        Console.Write("\b \n");
    }
}
