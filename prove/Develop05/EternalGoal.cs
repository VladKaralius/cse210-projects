public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int basePoints) 
        : base(name, description, basePoints)
    {

    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
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