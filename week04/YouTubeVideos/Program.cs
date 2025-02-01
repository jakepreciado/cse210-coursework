using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Basics", "John Doe", 300);
        video1.AddComment("Bob", "Great tutorial!");
        video1.AddComment("Dylan", "Very helpful, thanks!");
        video1.AddComment("Jane", "I dont know anything!");

        Video video2 = new Video("Advanced C#", "Jane Smith", 600);
        video2.AddComment("Dave", "This was a bit hard to follow.");
        video2.AddComment("Alice", "Loved the insights!");
        video2.AddComment("Olivia", "Good job!");

        Video video3 = new Video("Extra Advanced C# ", "Mike Brown", 450);
        video3.AddComment("Peter", "Extra Advanced C# awesome!");
        video3.AddComment("Hannah", "Well structured.");
        video3.AddComment("Matt", "Helpful examples!");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}