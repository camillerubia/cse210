using System;


public class Video
{
    private string _trackTitle;
    private string _author;
    private int _length;
    private List<Comment> _comments;


    private int GetCommentNumber()
    {
        return _length;
    }
}