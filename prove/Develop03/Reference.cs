    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int _verseEnd;
        private string _reference;
        private string _verseTextFull;
   
        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _reference = $"{_book} {_chapter}:{_verse}";

            VerseLibrary verseLibrary = new VerseLibrary();
            _verseTextFull = verseLibrary.GetVerse(_book, _chapter, _verse);
            Scripture scripture = new Scripture(_reference, _verseTextFull);
        }

        public Reference(string book, int chapter, int verse, int verseEnd)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _reference = $"{_book} {_chapter}:{_verse}";

            VerseLibrary verseLibrary = new VerseLibrary();
            for (int i = _verse; i <= _verseEnd; i++)
            {
                string verseText = verseLibrary.GetVerse(_book, _chapter, i);
                _verseTextFull += verseText + " ";
            }
            Scripture scripture = new Scripture(_reference, _verseTextFull);
        }
    }