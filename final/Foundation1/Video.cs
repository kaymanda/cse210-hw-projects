using System;
using System.Reflection;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;//in seconds
    
    public List<Comment> _comments = new List<Comment>();

    public Video()
    {

    }

    public void AddComments(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumComment()
    {
        return _comments.Count;
    }
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");

        Console.WriteLine($"The video has {GetNumComment()} comments:");

        foreach(Comment comment in _comments)
        {
           comment.Display(); 
        }
    }


}