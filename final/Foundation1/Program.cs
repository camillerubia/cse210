using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Foundation1 World!\n");

        List<Video> videos = new List<Video>();

        // Create videos and add comments
        Video video1 = new Video("Simplify Your Life with ABC: The Ultimate Solution for Everyday Challenges!", "Garance Zhenya", 120);
        video1.AddComment("Susanna Liora", "Great video!");
        video1.AddComment("Ansbert Zéphyrine", "Thanks for sharing!");
        video1.AddComment("Olusegun Alivia", "I learned a lot.");

        Video video2 = new Video("Step into the Future: PQR - The Next Generation of Tech Evolution!", "Daley Raimo", 180);
        video2.AddComment("Ciarán Wynn", "Awesome content!");
        video2.AddComment("Shivali Caolán", "Keep up the good work!");

        Video video3 = new Video("Unleash Your Creativity: Introducing XYZ - Inspiring the Artist Within!", "Melita Shukriyya", 150);
        video3.AddComment("Laurie River", "Very informative.");
        video3.AddComment("Tommie Nicky", "I have a question, can you help?");
        video3.AddComment("Lacey Hikari", "Can't wait to try it out!");
        video3.AddComment("Schuyler Purdie", "This video is eye-opening!");
        video3.AddComment("Pat Connie", "This video got me excited to try it!");


        videos.Add(video1);
        videos.Add(video2);    
        videos.Add(video3);

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._trackTitle}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("\nComments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"Commenter: {comment._commenterName}");
                Console.WriteLine($"Text: \"{comment._commentText}\"");
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}