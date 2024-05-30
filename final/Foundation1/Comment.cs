using System;
using System.Collections.Generic;

// Comment class to follow the person's name and comment text
public class Comment
{
    public string Author { get; set; }
    public string Text { get; set; }

    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
    }

    public override string ToString()
    {
        return $"{Author}: {Text}";
    }
}

