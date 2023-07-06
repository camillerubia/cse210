using System;
using System.Collections.Generic;

public class Video
{
    public string _trackTitle;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public Video (string trackTitle, string author, int length)
    {
        _trackTitle = trackTitle;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void AddComment(string commenter, string text)
    {
        _comments.Add(new Comment(commenter, text));
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}