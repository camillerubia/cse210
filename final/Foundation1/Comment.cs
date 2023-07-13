using System;

// COMMENT CLASS
// Responsibilities:
// - store name, text and the comment.
public class Comment
{
    // A field that stores the commenter name
    public string _commenterName;
    // A field that stores the comment text
    public string _commentText;

    // A constructor that receives the commenter name and the comment text
    // then stores it for local use.
    public Comment (string commenterName, string text)
    {
        _commenterName = commenterName;
        _commentText = text;
    }
}