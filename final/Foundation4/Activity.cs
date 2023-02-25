public abstract class Activity
{
    protected string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();

    public string GetSummary()
    {
        string type = GetType().Name.Replace("Activity", "");

        return  $"{_date} {type} ({_length} min): " +
                $"Distance: {GetDistance():F1} km, " +
                $"Speed: {GetSpeed():F1} kph, "+
                $"Pace: {GetPace():F1} min per km";
    }
}