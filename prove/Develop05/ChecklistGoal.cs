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
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetInfo()
    {
        return $"[ ] {_name} ({_description}) -- " +
            $"Curently completed: {_timesCompleted}/{_timesRequired}";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal~:~{_name}~|~{_description}~|~{_basePoints}~|~" +
            $"{_bonusPoints}~|~{_timesRequired}~|~{_timesCompleted}";
    }
}