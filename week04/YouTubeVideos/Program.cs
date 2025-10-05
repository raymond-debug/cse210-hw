using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Bake Bread", "Chef Kwame", 420);
        video1.AddComment(new Comment("Ama", "This was so helpful!"));
        video1.AddComment(new Comment("Kojo", "I tried it and it worked."));
        video1.AddComment(new Comment("Linda", "Can you do one for cake next?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 5 Ghanaian Tech Startups", "Raymond Nayel", 300);
        video2.AddComment(new Comment("Yaw", "Great list!"));
        video2.AddComment(new Comment("Esi", "I love Bibiani Tech Solutions."));
        video2.AddComment(new Comment("Kwabena", "You forgot Green Gold Farms."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("How to Fix a Flat Tire", "AutoWorks GH", 180);
        video3.AddComment(new Comment("Nana", "Saved me on the road."));
        video3.AddComment(new Comment("Abena", "Clear and easy to follow."));
        video3.AddComment(new Comment("Kofi", "Thanks for this!"));
        videos.Add(video3);

        // Display all videos
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(); // Blank line between videos
        }
    }
}