public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int basePoints) 
        : base(name, description, basePoints)
    {
    }

    public override int CompleteGoal()
    {
        return _basePoints; // Get points every time
    }

    public override bool IsComplete()
    {
        return false; // It is never complete
    }

    public override string GetInfo()
    {
        return $"[ ] {_name} ({_description})";
    }

    public override string Serialize()
    {
        return $"EternalGoal~:~{_name}~|~{_description}~|~{_basePoints}";
    }
}