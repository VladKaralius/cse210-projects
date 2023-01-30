    public class Scripture
    {
        private string _reference;
        private List<Word> _words;
        private List<int> _wordsDisplayed;
        private bool _isFullyHidden;

   
        public Scripture(string reference, string verse)
        {
            _reference = reference;

            _words = new List<Word>();

            string[] parts = verse.Split(" ");
            foreach (string part in parts)
            {
                Word word = new Word(part);
                _words.Add(word);
            }

            // Create a list that keeps track of displayed words
            // It contains indexes of the _words list
            _wordsDisplayed = new List<int>();

            for (int i = 0; i < _words.Count(); i++)
            {
                _wordsDisplayed.Add(i);
            }

            _isFullyHidden = false;
        }

        public string GetRenderedText()
        {
            string renderedText = "";
            foreach (Word word in _words)
            {
                renderedText += word.GetWord() + " ";
            }

            return renderedText;
        }

        public void HideWords()
        {
            for (int i = 0; i < 3; i++) // Hide three words
            {
                Random random = new Random();
                // Randomly choose one item from displayed words index list
                int choice = random.Next(_wordsDisplayed.Count());
                // Find out the index value
                int index = _wordsDisplayed[choice];
                // Hide the corresponding word
                _words[index].Hide();
                // Remove the hidden item from the list
                _wordsDisplayed.RemoveAt(choice);
                // If everything is hidden, set the attribute and end the loop
                if(_wordsDisplayed.Count() == 0)
                {
                    _isFullyHidden = true;
                    break;
                }
            }
        }

        public bool GetIsFullyHidden()
        {
            return _isFullyHidden;
        }
    }