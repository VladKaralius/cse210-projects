    public class ReferenceGenerator
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int _verseEnd;
        private string _fileName;
   
        public ReferenceGenerator()
        {
            _fileName = "mastery.txt";
            string[] lines = System.IO.File.ReadAllLines(_fileName);

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