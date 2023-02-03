
    public class ReflectionQuestionGenerator
    {
        private List<string> _reflectionQuestions;
           
        public ReflectionQuestionGenerator()
        {
            _reflectionQuestions = new List<string>
                {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                };
        }

        public string GetQuestion()
        {
            Random random = new Random();
            int index = random.Next(_reflectionQuestions.Count);
            return _reflectionQuestions[index];
        }
    }