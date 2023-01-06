using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string gradeLetter = "";
        string message = "";
        
        
        if (grade >= 90)
        {
            gradeLetter = "A";
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
        }
        else if (grade >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }


        if (grade >= 70)
        {
            message = "Congratulations. You have passed the course!";
        }
        else
        {
            message = "You failed the course. Better luck next time!";
        }


        Console.WriteLine($"Your grade is: {gradeLetter}");
        Console.WriteLine(message);
    }
}