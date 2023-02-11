public class SimpleGoal : Goal
{
    private bool _isComplete;
    
    public SimpleGoal(string name, string description, int basePoints) 
        : base(name, description, basePoints)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetInfo()
    {
        return $"[X] {_name} ({_description})";
    }
}