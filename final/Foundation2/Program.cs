using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        Random random = new Random();

        int choice = 0;
        while (choice != 5)
        {

            Console.WriteLine("Menu Options:\n" +
                              "  1. Create sample orders\n" +
                              "  2. Display total cost for each order\n" +
                              "  3. Display packing labels\n" +
                              "  4. Display shipping labels\n" +
                              "  5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                SampleDataGenerator sampleData = new SampleDataGenerator();
                orders.Clear();

                for (int i = 0; i < random.Next(3, 5); i++)
                {
                    Order order = new Order(sampleData.GetNextName());

                    string state;
                    string country;

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
                                        
                    order.SetCustomerAddress($"{sampleData.GetNextStreet()} {random.Next(1, 200)}",
                        sampleData.GetNextCity(), state, country);
                    
                    for (int j = 0; j < random.Next(3, 5); j++)
                    {
                        string productName = sampleData.GetNextProductName();
                        string productId = $"{productName.Substring(0, 3).ToUpper()}{random.Next(1, 100):00}";
                        decimal price = (decimal)random.Next(10, 10000) / 100;
                        int quantity = random.Next(1, 20);
                        order.AddProduct(productName, productId, price, quantity);
                    }         

                    orders.Add(order);
                }

                Console.WriteLine("\nOrders created.\n");
            }

            else if (choice == 2)
            {
                Console.WriteLine();
                
                // Some strings are formatted differently due to my regional settings.
                // I added this option to ensure uniform display.
                CultureInfo enUSCulture = new CultureInfo("en-US");
            
                foreach (Order order in orders)
                {
                    string totalCost = "$" + order.CalculateTotalCost().ToString(enUSCulture);
                    string customerName = order.GetCustomer().GetCustomerName();
                    Console.WriteLine($"Total cost: {totalCost,8}   " +
                    $"Shipping cost (included): {"$" + order.GetShippingCost(),3}   Customer: {customerName}");
                }

                Console.WriteLine();
            }

            else if (choice == 3)
            {
                Console.WriteLine();
                
                foreach (Order order in orders)
                {
                    string customerName = order.GetCustomer().GetCustomerName();
                    Console.WriteLine($"Customer: {customerName}\n" + new string('-', 29));
                    Console.WriteLine(order.GetPackingLabel());
                }
            }

            else if (choice == 4)
            {
                Console.WriteLine();

                foreach (Order order in orders)
                {
                    Console.WriteLine(order.GetShippingLabel() + "\n");
                }
            }
        }
    }
}