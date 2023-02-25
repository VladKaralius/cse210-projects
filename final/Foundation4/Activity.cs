public abstract class Activity
{
    private string _date;
    private int _length;

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
        return  $"{_date} TYPE ({_length} min): " +
                $"Distance: {GetDistance()} km, " +
                $"Speed: {GetSpeed()} kph, "+
                $"Pace: {GetPace()} min per km";
    }
}