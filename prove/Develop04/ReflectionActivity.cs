public class ReflectionActivity : Activity
{
    private ReflectionPromptGenerator _reflectionPromptGenerator;
    private ReflectionQuestionGenerator _reflectionQuestionGenerator;

    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life " + 
            "when you have shown strength and resilience. This will help you recognize " +
            "the power you have and how you can use it in other aspects of your life.";
        _reflectionPromptGenerator = new ReflectionPromptGenerator();
        _reflectionQuestionGenerator = new ReflectionQuestionGenerator();
    }

    public void RunActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        _animation.Display(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine(_reflectionPromptGenerator.GetPrompt());
        Console.WriteLine(_reflectionQuestionGenerator.GetQuestion());
        
        while (DateTime.Now < endTime)
        {

        }
    }
}
