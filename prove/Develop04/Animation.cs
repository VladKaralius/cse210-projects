public class Animation
{
    public Animation()
    {
    }

    public void Display(int duration)
    {
        int cycles = duration * 5 / 6;
        
        Console.Write(" ");

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("\b \b-");
            Thread.Sleep(400);
            Console.Write("\b \b\\");
            Thread.Sleep(400);
            Console.Write("\b \b/");
            Thread.Sleep(400);
        }

        Console.Write("\b \b\n");
    }
}
