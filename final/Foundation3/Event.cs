public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    private Address _address;

    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }

    public void SetAddress(string streetAddress,
        string city, string state, string country)
    {
        _address= new Address(streetAddress, city, state, country);
    }

    public string GetStandardDetails()
    {
        string standardDetails = $"You are invited to attend: {_title}\n" +
            $"{_description}\nTo be held on {_date} at {_time}\n" +
            $"Location: {_address.GetFullAddress()}";
        
        return standardDetails;
    }

    public string GetShortDescription()
    {
        string type = GetEventType();
        return $"{_date,10} - {type,-15} - {_title}";
    }

    public abstract string GetFullDetails();

    protected string GetEventType()
    {
        string type = GetType().Name.Replace("Event", " event");
        return type;
    }
}
