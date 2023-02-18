public class ProgressBar
{
    int _length;

    public ProgressBar(int length)
    {
        _length = length;
    }

    public void Display(int pointsTillNextLevel, int pointDifference)
    {
        int pointsPerSegment = pointDifference / _length;
        int completeSegments = (pointDifference - pointsTillNextLevel) / pointsPerSegment;
        
        // I had to add some symbol at the beginning of the bar.
        // Otherwise the colors were not displayed as I expected.
        // It seems I am missing some nuances here.
        Console.Write("> ");
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.Write(new string(' ', completeSegments));
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Write(new string(' ', _length - completeSegments));
        Console.ResetColor();
        Console.WriteLine("\n");
    }
}