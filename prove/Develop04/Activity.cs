public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected Animation _animation;
    protected Countdown _countdown;

    public Activity()
    {
        _animation = new Animation();
        _countdown = new Countdown();
    }



    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }



    public void DisplayEndingMessage()
    {
        string endingMessage = $"You have completed another {_duration} " +
            $"seconds of the {_name}";
        Console.WriteLine(endingMessage);
    }
}
