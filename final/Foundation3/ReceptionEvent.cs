public class ReceptionEvent : Event
{
    private string _responseEmail;

    public ReceptionEvent(string title, string description, string date, string time,
        string responseEmail) : base(title, description, date, time)
    {
        _responseEmail = responseEmail;
    }

    public override string GetFullDetails()
    {
        string fullDetails = GetStandardDetails();
        string type = GetEventType();
        fullDetails += $"\n{type}. Please RSVP to {_responseEmail}.";
        return fullDetails;
    }
}