public class Program
{
    public static void Main(string[] args)
    {
        // Create a few videos
        Video video1 = new Video("Presentation of various skin care products", "Anne Lea Duperville", 300);
        Video video2 = new Video("How to use the latest microwave model?", "Jane Smith", 600);
        Video video3 = new Video("Special 20% discount for regular customers", "Alice Johnson", 450);

        // Add comments to videos
        video1.AddComment(new Comment("Billy Pellage", "Great video! I really appreciate how you described the benefits of each product and how they can be incorporated into a daily routine."));
        video1.AddComment(new Comment("Regine Loucina", "The section on face masks was very informative. Keep up the good work."));
        video1.AddComment(new Comment("Briana Belo", "I particularly liked the recommendations for sensitive skin."));

        video2.AddComment(new Comment("Willanda Nordelus", "Thank you for this detailed tutorial! I was a little intimidated by all the features of my new microwave."));
        video2.AddComment(new Comment("David Elinord", "Awesome! This video gave me a whole new perspective on my microwave. I didn't even know it had so many practical functions."));
        video2.AddComment(new Comment("Baselaire Pierre", "Cette vidéo m'a vraiment donné confiance pour utiliser mon micro-ondes de manière optimale. Merci beaucoup !"));

        video3.AddComment(new Comment("Jovenel Moïse", "Thank you so much! I will definitely take the opportunity to shop with you."));
        video3.AddComment(new Comment("Stevenson Baptiste", "This 20% discount is an excellent incentive to continue shopping with you. Thank you for this special offer!"));
        video3.AddComment(new Comment("Flore Melissa", "Wow, a 20% discount for regular customers? That's really impressive!"));

        // Adding videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information on each video and its comments
        foreach (var video in videos)
        {
            Console.WriteLine(video);
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine(comment);
            }
            Console.WriteLine(); 
        }
    }
}