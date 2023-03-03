public class OutdoorEvent : Event
{
    private string _weatherForecast;

    public OutdoorEvent(string title, string description, string date, string time,
        string weatherForecast) : base(title, description, date, time)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        string fullDetails = GetStandardDetails();
        string type = GetEventType();
        fullDetails += $"\n{type}. Expected weather: {_weatherForecast}";
        return fullDetails;
    }
}