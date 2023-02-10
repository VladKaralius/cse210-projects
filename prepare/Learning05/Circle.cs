public class Circle : Shape
{
    private double _radius;

    public Circle(string name, double radius) : base(name)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return 3.14 * _radius * _radius;
    }
}