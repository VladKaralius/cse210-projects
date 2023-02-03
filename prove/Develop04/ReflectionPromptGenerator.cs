
    public class ReflectionPromptGenerator
    {
        private List<string> _reflectionPrompts;
           
        public ReflectionPromptGenerator()
        {
            _reflectionPrompts = new List<string>
                {
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."
                };
        }

        public string GetPrompt()
        {
            Random random = new Random();
            int index = random.Next(_reflectionPrompts.Count);
            return _reflectionPrompts[index];
        }
    }