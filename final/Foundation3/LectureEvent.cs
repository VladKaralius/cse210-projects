public class LectureEvent : Event
{
    private string _speakerName;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time,
        string speakerName, int capacity) : base(title, description, date, time)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        string fullDetails = GetStandardDetails();
        string type = GetEventType();
        fullDetails += $"\n{type}. Speaker {_speakerName}, capacity {_capacity} seats.";
        return fullDetails;
    }
}