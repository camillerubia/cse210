using System;


public class Comment
{
    private string _completeComment;
    private string _commenterName;
    private string _commentText;
    private string _comment;

    public Comment (string commenterName, string text)
    {

    }
    public string GetComment()
    {
        return _comment;
    }
}