public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseEnd;
    private string _fullReference;
    private string _verseTextFull;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _fullReference = $"{_book} {_chapter}:{_verse}";

        VerseLibrary verseLibrary = new VerseLibrary();
        _verseTextFull = verseLibrary.GetVerseText(_book, _chapter, _verse);
    }

    public Reference(string book, int chapter, int verse, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verseEnd = verseEnd;
        
        _fullReference = $"{_book} {_chapter}:{_verse}-{_verseEnd}";

        VerseLibrary verseLibrary = new VerseLibrary();
        for (int i = _verse; i <= _verseEnd; i++)
        {
            string verseText = verseLibrary.GetVerseText(_book, _chapter, i);
            _verseTextFull += verseText + " ";
        }
    }

    public string GetFullReference()
    {
        return _fullReference;
    }

    public string GetVerseTextFull()
    {
        return _verseTextFull;
    }
}