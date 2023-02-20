public class Video
{
    string _title;
    string _author;
    int _length;
    List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }

    public string GetTitle() => _title;
    public string GetAuthor() => _author;
    public int GetLength() => _length;
    public List<Comment> GetComments() => _comments;
}