public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    
    /* These classes could simply be implemented as methods in the Activity class.
    However, I felt that this functionality is distinct enough and
    decided to move it into separate classes for easier handling.
    Indeed, I modified those classes several times without touching the Activity class. */
    protected Animation _animation;
    protected Countdown _countdown;

    // Tracking data will be stored in dictionaries:
    private static Dictionary<string, int> _activationCount =
        new Dictionary<string, int>(){
            {"Breathing", 0},
            {"Reflection", 0},
            {"Listing", 0}
        };
    private static Dictionary<string, int> _totalDuration =
        new Dictionary<string, int>(){
            {"Breathing", 0},
            {"Reflection", 0},
            {"Listing", 0}
        };

    public Activity()
    {
        _animation = new Animation();
        _countdown = new Countdown();
        // Keep track of activations.
        _activationCount[_name]++;
    }

    public void RunStartingSequence()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        _animation.Display(5);
        // Keep track of total duration.
        _totalDuration[_name] += _duration;
    }

    public void RunEndingSequence()
    {
        Console.WriteLine("\nWell done!!");
        _animation.Display(5);
       Console.WriteLine($"You have completed another {_duration} " +
            $"seconds of the {_name} Activity.");
        _animation.Display(5);
    }

    // Showing Creativity and Exceeding Requirements
    public static void DisplayReport()
    {
        Console.Clear();
        Console.WriteLine("Statistics for this session\n");
        int grandTotal = 0;
        foreach (KeyValuePair<string, int> entry in _activationCount)
        {
            Console.WriteLine($"You have completed the {entry.Key} Activity {entry.Value} time(s) " +
                $"for a total duration of {_totalDuration[entry.Key]} seconds.");
            grandTotal += _totalDuration[entry.Key];
        }
        Console.WriteLine($"\nYou spent {grandTotal} seconds on all activities.");
        Console.WriteLine("\nPress enter to continue...");
        Console.ReadLine();
    }
}
