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
}