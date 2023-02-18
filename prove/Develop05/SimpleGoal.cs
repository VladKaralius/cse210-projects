public class SimpleGoal : Goal
{
    private bool _isComplete;
    
    public SimpleGoal(string name, string description, int basePoints) 
        : base(name, description, basePoints)
    {
        _isComplete = false;
    }

    public override int CompleteGoal()
    {
        if (_isComplete)
        {
            // If it is already completed get 0 points.
            return 0;
        }
        else
        {
            _isComplete = true;
            return _basePoints;
        }
    }

    public override bool IsComplete()
    {
        // Return completion state.
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

    public override string Serialize()
    {
        return $"SimpleGoal~:~{_name}~|~{_description}~|~{_basePoints}~|~{_isComplete}";
    }

    // Used when loading goals from a file.
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
}