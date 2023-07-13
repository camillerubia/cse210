using System;
using System.Collections.Generic;

// VIDEO CLASS
// Responsibilities:
// - Store the title, author and length
// - Collect comments and store in a list

public class Video
{
    // A field that stores video title.
    public string _trackTitle;
    // A field that stores the name of the video creator.
    public string _author;
    // A field that stores the duration of the video in seconds
    public int _length;
    // Instantiates a list with the comment type to store all the comments for the video
    public List<Comment> _comments;

    // A constructor that receives the title, cretor and the video duration
    // then stores for local use which then creates a new list of comments whenever the class
    // is instantiated.
    public Video (string trackTitle, string author, int length)
    {
        _trackTitle = trackTitle;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    // A method that returns the number of comments from the list.
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // A method that adds comments in the list which receives the parameters of the Comment class
    // Then adds each comment into the list.
    public void AddComment(string commenter, string text)
    {
        _comments.Add(new Comment(commenter, text));
    }

    // A method that returns the created list of comments for the video
    public List<Comment> GetComments()
    {
        return _comments;
    }
}