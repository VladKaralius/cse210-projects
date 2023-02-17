public class Level
{
    private int _increase = 100;
    // First level requires 100 points, second - 200, third - 300, each increasing by 100.
    // Total points required can be calculated using Gauss formula:
    // sum = (n / 2) * (first_number + last_number), where n is the number of integers.
    // Then we need to multiply it by 100. Since we always start with 1, we can simplify it:
    // points = level * (1 + level) / 2 * 100

    public Level()
    {
    }

    public void Display(int pointTotal, int pointsReceived)
    {
        int level = PointsToLevel(pointTotal);
        int newPointTotal = pointTotal + pointsReceived;
        int newLevel = PointsToLevel(newPointTotal);
        int pointsTillNextLevel = LevelToPoints(newLevel + 1) - newPointTotal;
        int levelGain = newLevel - level;

        Console.ForegroundColor = ConsoleColor.Green;

        if (levelGain == 1)
        {
            Console.WriteLine("Level up! Congratulations, you gained a level!");
        }
        else if (levelGain > 1)
        {
            Console.WriteLine($"Level up! Congratulations, you gained {levelGain} levels!");
        }

        Console.Write("Your level: ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(newLevel);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(".  Points to the next level: ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(pointsTillNextLevel);
        
        Console.ResetColor();
    }

    private int PointsToLevel(int points)
    {
        int level = (int)(Math.Sqrt(8 * points / _increase + 1) - 1) / 2;
        return level;
    }

    private int LevelToPoints(int level)
    {
        int points = (level + level * level) / 2 * _increase;
        return points;
    }
}