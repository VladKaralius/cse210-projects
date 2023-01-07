using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        int sum = 0;
        double average = 0;
        int largest = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
                numbers.Add(number);
            }
            
            if (number > largest)
            {
                largest = number;
            }
            
            sum += number;
        }

        average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}