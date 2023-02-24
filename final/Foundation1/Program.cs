using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Random random = new Random();

        int choice = 0;
        while (choice != 3)
        {
            Console.WriteLine("Menu Options:\n" +
                              "  1. Create videos with sample data\n" +
                              "  2. Display list of videos with comments\n" +
                              "  3. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                SampleDataGenerator sampleData = new SampleDataGenerator();
                videos.Clear();

                // Create 3 or 4 videos.
                for (int i = 0; i < random.Next(3, 5); i++)
                {
                    string title = sampleData.GetNextTitle();
                    string author = sampleData.GetNextName();
                    int length = random.Next(200, 1500);

                    Video video = new Video(title, author, length);

                    // Add 3 or 4 comments to each video.
                    for (int j=0; j < random.Next(3, 5); j++)
                    {
                        string name = sampleData.GetNextName();
                        string text = sampleData.GetNextText();
                        
                        video.AddComment(name, text);
                    }
                    
                    videos.Add(video);
                }

                Console.WriteLine("\nVideos created.\n");
            }

            else if (choice == 2)
            {
                Console.WriteLine();
                
                foreach (Video video in videos)
                {
                    Console.WriteLine($"{video.GetTitle()} " +
                        $"({video.GetLength()} s) by {video.GetAuthor()}");

                    foreach (Comment comment in video.GetComments())
                    {
                        Console.WriteLine($"    {comment.GetName()}: {comment.GetText()}");
                    }
                    
                    Console.WriteLine();
                }
            }
        }
    }
}