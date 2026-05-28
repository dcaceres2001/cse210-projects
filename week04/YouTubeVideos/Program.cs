using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello YouTube Videos!");
            // Create some videos
            Video video1 = new Video("C# Tutorial", "John Doe", 230);
            Video video2 = new Video("Learn Python", "Jane Smith", 900);
            Video video3 = new Video("JavaScript Basics", "Emily Davis", 450);
            Video video4 = new Video("Python for beginners", "Douglas Caceres", 100);
            // Add comments to video1
            video1.AddComment(new Comment("Alice", "Great tutorial!"));
            video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
            video1.AddComment(new Comment("Eve", "Can you make a video on C# advanced topics?"));

            // Add comments to video2
            video2.AddComment(new Comment("Charlie", "I love Python!"));
            video2.AddComment(new Comment("Dave", "Can't wait to try this out!"));
            video2.AddComment(new Comment("Frank", "Please make a video on Python data science!"));
            // Add comments to video3
            video3.AddComment(new Comment("Grace", "JavaScript is so cool!"));
            video3.AddComment(new Comment("Henry", "Great explanation!"));
            video3.AddComment(new Comment("Ivy", "Can you make a video on JavaScript frameworks?"));
            // Add comments to video4
            video4.AddComment(new Comment("Ivy", "Very beginner-friendly!"));
            video4.AddComment(new Comment("Jack", "Thanks for this helpful intro!"));
            video4.AddComment(new Comment("Kate", "Great video for learning Python!"));
            // Display video information and comments
            DisplayVideoInfo(video1);
            DisplayVideoInfo(video2);
            DisplayVideoInfo(video3);
            DisplayVideoInfo(video4);
        }

        static void DisplayVideoInfo(Video video)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetComments().Count}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetAuthor()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}



