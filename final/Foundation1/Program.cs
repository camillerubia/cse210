using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new List<Video>();

        // Create videos and add comments
        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "Thanks for sharing!");
        video1.AddComment("User3", "I learned a lot.");

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.AddComment("User1", "Awesome content!");
        video2.AddComment("User2", "Keep up the good work!");

        Video video3 = new Video("Video 3", "Author 3", 150);
        video3.AddComment("User1", "Very informative.");
        video3.AddComment("User2", "I have a question, can you help?");

        videos.Add(video1);
        videos.Add(video2);    
        videos.Add(video3);

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video._trackTitle);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine("Commenter: " + comment._commenterName);
                Console.WriteLine("Text: " + comment._commentText);
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}