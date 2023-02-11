public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _timesRequired;
    private int _bonusPoints;

    
    public ChecklistGoal
        (string name, string description, int basePoints, int timesRequired, int bonusPoints) 
        : base(name, description, basePoints)
    {
        _timesCompleted = 0;
        _bonusPoints = bonusPoints;
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
        return $"[ ] {_name} ({_description}) -- " +
            $"Curently completed: {_timesCompleted}/{_timesRequired}";
    }
}