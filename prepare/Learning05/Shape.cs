public class Shape
{
    protected string _color;

    public Shape()
    {

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