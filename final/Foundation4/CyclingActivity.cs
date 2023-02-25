public class CyclingActivity : Activity
{
    private float _speed;

    public CyclingActivity(string date, int length, float speed)
        : base(date, length)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return _speed / 60 * _length;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        return 60 / _speed;
    }
}