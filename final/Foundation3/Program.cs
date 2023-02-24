using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        CultureInfo enUSCulture = new CultureInfo("en-US");
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

                // Create 6 orders (2 of each type)
                for (int i = 0; i < 6; i++)
                {
                    string title = sampleData.GetNextTitle();
                    string description = sampleData.GetNextDescription();
                    
                    DateTime date = DateTime.Now.AddDays(random.Next(10, 60));
                    string dateText = date.ToString("d", enUSCulture);
                    DateTime time = new DateTime(2023, 3, 1, 8, 0, 0).AddMinutes(random.Next(0, 21) * 30);
                    string timeText = time.ToString("t", enUSCulture);
                    
                    string streetAddress = sampleData.GetNextStreet();
                    // Add a random house number.
                    streetAddress += " " + random.Next(1, 200);
                    string city = sampleData.GetNextCity();

                    string state;
                    string country;
                    // About one address in four will be from USA.
                    // Use real state name for USA and imaginary for other countries.
                    if (random.Next(0, 2) == 0)
                    {
                        state = sampleData.GetNextStateUSA();
                        country = "USA";
                    }
                    else
                    {
                        state = sampleData.GetNextState();
                        country = sampleData.GetNextCountry();
                    }

                  
                    Event event_ = new Event(title, description, dateText, timeText);

                    // Add event address.
                    event_.SetAddress(streetAddress, city, state, country);
                    events.Add(event_);
                }

                Console.WriteLine("\nEvents created.\n");
            }

            else if (choice == 2)
            {
                Console.WriteLine();

                foreach (Event event_ in events)
                {
                    Console.WriteLine(event_.GetStandardDetails() + "\n");
                }
            }

            else if (choice == 3)
            {
                Console.WriteLine();

                Console.WriteLine("Not implemented");

                Console.WriteLine();
            }

            else if (choice == 4)
            {
                Console.WriteLine();
                
                foreach (Event event_ in events)
                Console.WriteLine(event_.GetShortDescription());

                Console.WriteLine();
            }
        }
    }
}