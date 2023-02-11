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
        return _isComplete;
    }

    public override string GetInfo()
    {
        string checkmark = " ";
        if (_isComplete)
        {
            checkmark = "X";
        }
        return $"[{checkmark}] {_name} ({_description})";
    }
}