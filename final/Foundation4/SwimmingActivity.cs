public class SwimmingActivity : Activity
{
    private int _numberOfLaps;

    public SwimmingActivity(string date, int length, int numberOfLaps)
        : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override float GetDistance()
    {
        return (float)_numberOfLaps * 50 / 1000;
    }

    public override float GetSpeed()
    {
        return GetDistance() / _length * 60;
    }

    public override float GetPace()
    {
        return 60 / GetSpeed();
    }
}