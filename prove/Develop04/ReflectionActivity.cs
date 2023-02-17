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
        // Keep track of activations.
        _activationCount[_name]++;
    }

    public void RunActivity()
    {
        Console.WriteLine("Consider the following prompt:\n");
        string prompt = _reflectionPromptGenerator.GetPrompt();
        Console.WriteLine($" --- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder of each of the following questions " +
            "as they related to this experience");
        Console.Write("You may begin in: ");
        _countdown.Display(5);
        Console.Clear();
    
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
                
        while (DateTime.Now < endTime)
        {
            string question = _reflectionQuestionGenerator.GetQuestion();
            Console.Write($"> {question} ");
            _animation.Display(16);
        }
    }
}
