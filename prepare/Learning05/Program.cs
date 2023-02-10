using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 5);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("green", 5, 10);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());
        
        Circle circle = new Circle("blue", 5);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        List<Shape> list = new List<Shape>();
        list.Add(square);
        list.Add(rectangle);
        list.Add(circle);

        Console.WriteLine("Display list");

        foreach (Shape shape in list)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}