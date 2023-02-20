public class Comment
{
    string _name;
    string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string GetName() => _name;
    public string GetText() => _text;

}