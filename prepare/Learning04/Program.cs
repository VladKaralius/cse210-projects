using System;

class Program
{
    static void Main(string[] args)
    {
    Assignment testBase = new Assignment("Samuel Bennet", "Multiplication");
    Console.WriteLine(testBase.GetSummary());

    MathAssignment testMath = new MathAssignment("Roberto Rodriguez",
        "Fractions", "7.3", "8-19");
    Console.WriteLine(testMath.GetSummary());
    Console.WriteLine(testMath.GetHomeworkList());

    WritingAssignment testWriting = new WritingAssignment("Mary Waters",
        "European History", "The Causes of World War II");
    Console.WriteLine(testWriting.GetSummary());
    Console.WriteLine(testWriting.GetWritingInformation());
       
    }




}