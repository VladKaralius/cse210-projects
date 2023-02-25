public class RunningActivity : Activity
{
    private float _distance;

    public RunningActivity(string date, int length, float distance)
        : base(date, length)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return 1.1F;
    }

    public override float GetSpeed()
    {
        return 2.2F;
    }

    public override float GetPace()
    {
        return 3.3F;
    }
}