using System;
using System.Collections.Generic;


public class Video
{
    private string _trackTitle;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video (string trackTitle, string author, int length)
    {
        _trackTitle = trackTitle;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    private int GetCommentNumber()
    {
        return _comments.Count;
    }
}