using System;
using System.Collections.Generic;

class VideoComment
{
    public string CommenterName;
    public string Text;

    public VideoComment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

class Video
{
    public string Title;
    public string Author;
    public int LengthSeconds;
    public List<VideoComment> Comments = new List<VideoComment>();

    public Video(string title, string author, int lengthSeconds)
    {
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        var video1 = new Video("Learn C#", "Mignon", 600);
        video1.Comments.Add(new VideoComment("Alice", "Great tutorial!"));
        video1.Comments.Add(new VideoComment("Bob", "Very clear, thanks."));
        video1.Comments.Add(new VideoComment("Charlie", "I learned a lot."));

        var video2 = new Video("Introduction to AI", "Professor X", 1200);
        video2.Comments.Add(new VideoComment("David", "Fascinating!"));
        video2.Comments.Add(new VideoComment("Emma", "I love this topic."));
        video2.Comments.Add(new VideoComment("Frank", "Well explained."));

        var video3 = new Video("Relaxing Music", "DJ Zen", 1800);
        video3.Comments.Add(new VideoComment("Gina", "This is really calming."));
        video3.Comments.Add(new VideoComment("Hugo", "Perfect for working."));
        video3.Comments.Add(new VideoComment("Isabelle", "Beautiful!"));

        // List of videos
        var videos = new List<Video> { video1, video2, video3 };

        // Display
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}

