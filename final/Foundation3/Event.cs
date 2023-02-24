public class Event
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
        string standardDetails = $"Invitation to the event: {_title}\n" +
            $"{_description}\n{_date} {_time}\n{_address.GetFullAddress()}";
        
        return standardDetails;
    }

    public string GetShortDescription()
    {
        string type = GetType().Name;
        return $"{type} | {_title} | {_date}";
    }
}
