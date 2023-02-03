public class Animation
{
    public Animation()
    {
    }

    public void Display(int duration)
    {
        int cycles = duration * 2 / 3;
        
        Console.Write(" ");

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("\b \b-");
            Thread.Sleep(500);
            Console.Write("\b \b\\");
            Thread.Sleep(500);
            Console.Write("\b \b/");
            Thread.Sleep(500);
        }

        Console.Write("\b \b\n");
    }
}
