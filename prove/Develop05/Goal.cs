public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _basePoints;

    public Goal(string name, string description, int basePoints)
    {
        _name = name;
        _description = description;
        _basePoints = basePoints;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract int CompleteGoal();
    public abstract bool IsComplete();
    public abstract string GetInfo();
    public abstract string Serialize();
}