public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _timesRequired;
    private int _timesCompleted;
        
    public ChecklistGoal
        (string name, string description, int basePoints, int bonusPoints, int timesRequired) 
        : base(name, description, basePoints)
    {
        _bonusPoints = bonusPoints;  
        _timesRequired = timesRequired;
        _timesCompleted = 0;
    }

    public override int CompleteGoal()
    {
        if (_timesCompleted == _timesRequired)
        {
            // If it is already completed get 0 points.
            return 0;
        }
        else
        {
            _timesCompleted++;

            if (_timesCompleted == _timesRequired)
            {
                return _basePoints + _bonusPoints;
            }
            else
            {
                return _basePoints;
            }
        }
    }

    public override bool IsComplete()
    {
        if (_timesCompleted == _timesRequired)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetInfo()
    {
        string checkmark = " ";
        if (_timesCompleted == _timesRequired)
        {
            checkmark = "X";
        }
        return $"[{checkmark}] {_name} ({_description}) -- " +
            $"Curently completed: {_timesCompleted}/{_timesRequired}";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal~:~{_name}~|~{_description}~|~{_basePoints}~|~" +
            $"{_bonusPoints}~|~{_timesRequired}~|~{_timesCompleted}";
    }

    // Used when loading goals from a file.
    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted = timesCompleted;
    }
}