public class BreathingActivity : Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private int _duration;

    public BreathingActivity(string activityName, int duration)
    {
        _startingMessage = $"Welcome to the {activityName}.";
        _endingMessage = $"You have completed another {duration} " +
            $"seconds of the {activityName}";
        _duration = duration;
    }

    public string GetSummary()
    {
        return $"{_duration} - {_duration}";
    }
}
