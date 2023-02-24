using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        List<Event> events = new List<Event>();
        
        int choice = 0;
        while (choice != 5)
        {

            Console.WriteLine("Menu Options:\n" +
                              "  1. Create sample events\n" +
                              "  2. Display standard details\n" +
                              "  3. Display full details\n" +
                              "  4. Display short descriptions\n" +
                              "  5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                SampleDataGenerator sampleData = new SampleDataGenerator();
                events.Clear();

                Event event_ = new Event(sampleData.GetNextTitle(),
                    sampleData.GetNextDescription(), "soon", "soon");

                string state;
                string country;

                if (random.Next(0, 4) == 0)
                {
                    state = sampleData.GetNextStateUSA();
                    country = "USA";
                }
                else
                {
                    state = sampleData.GetNextState();
                    country = sampleData.GetNextCountry();
                }

                event_.SetAddress($"{sampleData.GetNextStreet()} {random.Next(1, 200)}",
                        sampleData.GetNextCity(), state, country);
                events.Add(event_);

                Console.WriteLine("\nEvents created.\n");
            }

            else if (choice == 2)
            {
                foreach (Event event_ in events)
                Console.WriteLine(event_.GetStandardDetails());
            }

            else if (choice == 3)
            {
                Console.WriteLine("Not implemented");
            }

            else if (choice == 4)
            {
                Console.WriteLine("Not implemented");
            }
        }
    }
}