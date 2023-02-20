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
                              "  1. Populate with random sample data\n" +
                              "  2. Display sample data\n" +
                              "  3. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                SampleDataGenerator sampleData = new SampleDataGenerator();
                
                videos.Clear();
                for (int i = 0; i < random.Next(3, 5); i++)
                {
                    Video video = new Video(sampleData.GetNextTitle(),
                        sampleData.GetNextName(), random.Next(200, 1500));
                    
                    for (int j=0; j < random.Next(3, 5); j++)
                    {
                        video.AddComment(sampleData.GetNextName(), sampleData.GetNextText());
                    }
                    
                    videos.Add(video);
                }
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