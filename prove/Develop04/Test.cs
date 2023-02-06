public class Test
{

    string _name;

    public Test()
    {

    }

    
    public void RunActivity(string name)
    {
        _name = name;
        Type type = Type.GetType("BreathingActivity",true);
        object currentActivity = Activator.CreateInstance(type);
        Console.Clear();
        //currentActivity.RunActivity();

        Console.WriteLine(currentActivity.GetType());
        Console.ReadLine();
        

    }


}