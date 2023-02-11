public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int basePoints) 
        : base(name, description, basePoints)
    {

    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override void IsComplete()
    {
        throw new NotImplementedException();
    }
}