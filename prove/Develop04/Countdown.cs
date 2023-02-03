public class Countdown
{
    public Countdown()
    {
    }

    public void Display(int duration)
    {
        Console.Write(" ");

        for (int i = duration; i > 0; i--)
        {
            Console.Write($"\b \b{i}");
            Thread.Sleep(1000);
        }

        Console.Write("\b \b\n");
    }
}
