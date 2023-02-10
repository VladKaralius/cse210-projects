using System;

class Program
{
    static void Main(string[] args)
    {

        Square square = new Square("red", 5);
        Shape shape = new Shape("red");
        Console.WriteLine(square.GetArea());
        Console.WriteLine(square.GetColor());
        Console.WriteLine(shape.GetArea());
    }
}