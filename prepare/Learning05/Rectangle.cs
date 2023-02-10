public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string name, double length, double width) : base(name)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}