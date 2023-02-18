public class Level
{
    private int _increase = 100;
    // First level requires 100 points, second - 200, third - 300, and so on, each increasing by 100.
    // Total points required can be calculated using Gauss formula:
    // sum = (n / 2) * (first_number + last_number), where n is the number of integers.
    // Then we need to multiply it by 100. Since we always start with 1, we can simplify it:
    // points = level * (1 + level) / 2 * 100

    private ProgressBar _progressBar;

    public Level()
    {
        _progressBar = new ProgressBar(50);
    }

    public void LevelUp(int pointTotal, int pointsReceived)
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
        
        Console.ResetColor();
    }    
    
    public void Display(int pointTotal)
    {
        int level = PointsToLevel(pointTotal);
        int pointsTillNextLevel = LevelToPoints(level + 1) - pointTotal;
        int pointDifference = LevelToPoints(level +1) - LevelToPoints(level);
    
        Console.Write("> ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Your level: ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(level);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("   Points to the next level: ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(pointsTillNextLevel);
        Console.ResetColor();
        _progressBar.Display(pointsTillNextLevel, pointDifference);

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