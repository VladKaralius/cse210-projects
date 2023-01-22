    public class Word
    {
        private string _word;
        private bool _isHidden;
   
        public Word(string word)
        {
            _word = word;
            _isHidden = false;
        }

        public string GetWord()
        {
            if (_isHidden == false)
            {
                return _word;
            }

            else
            {
                return new string('_', _word.Length);
            }
        }

        public void Hide()
        {
            _isHidden = true;
        }
    }