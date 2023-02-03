public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through " + 
            "breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RunActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        _animation.Display(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.Write("\nBreath in...");
        _countdown.Display(2);
        Console.Write("Now breath out...");
        _countdown.Display(3);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            _countdown.Display(4);
            Console.Write("Now breath out...");
            _countdown.Display(6);
        }
    }
}
