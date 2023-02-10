public class Shape
{
    protected string _color;

    public Shape()
    {
        Console.WriteLine("Shape created");
    }

    public string GetColor()
    {
        return "";
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }






}