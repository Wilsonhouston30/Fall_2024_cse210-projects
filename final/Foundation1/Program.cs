using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Create video objects
        Video video1 = new Video("How to wrap presents", "Santa", 600);
        Video video2 = new Video("How to tie a tie", "Jaysom Tatum", 900);
        Video video3 = new Video("Team1 vs Team2", "NFL", 1200);

        // Add comments to video1
        video1.AddComment(new Comment("Ms. Clause", "Keep up the great work"));
        video1.AddComment(new Comment("Know-it-all", "I can't wait to go back to the north pole"));
        video1.AddComment(new Comment("Buddy", "Santa!"));

        // Add comments to video2
        video2.AddComment(new Comment("Lebron James", "Good job kid"));
        video2.AddComment(new Comment("Celtics", "YOU DID IT!"));
        video2.AddComment(new Comment("Jaylon Brown", "I'm amazed"));

        // Add comments to video3
        video3.AddComment(new Comment("Rick", "I can't beleive we lost again"));
        video3.AddComment(new Comment("Tony", "Superbowl 2 here we come"));
        video3.AddComment(new Comment("Maisyn", "Go Hawks"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}