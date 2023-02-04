public class Animation
{
    public Animation()
    {
    }

    public void Display(int duration)
    {
        int cycles = duration;
        
        Console.Write(" ");

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("\b \b-");
            Thread.Sleep(300);
            Console.Write("\b \b\\");
            Thread.Sleep(200);
            Console.Write("\b \b|");
            Thread.Sleep(200);
            Console.Write("\b \b/");
            Thread.Sleep(300);
        }

        Console.Write("\b \b\n");
    }
}
