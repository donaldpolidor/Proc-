public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; } // Time in seconds
    private List<Comment> comments;

    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }

    public override string ToString()
    {
        return $"{Title} by {Author}, Duration: {Duration} seconds, Comments: {GetCommentCount()}";
    }
}