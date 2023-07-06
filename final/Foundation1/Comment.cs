using System;


public class Comment
{
    public string _completeComment;
    public string _commenterName;
    public string _commentText;
    public string _comment;

    public Comment (string commenterName, string text)
    {
        _commenterName = commenterName;
        _commentText = text;
    }
    public string GetComment()
    {
        return _comment;
    }
}