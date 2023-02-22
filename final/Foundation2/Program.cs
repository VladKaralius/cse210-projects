using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        Random random = new Random();

        int choice = 0;
        while (choice != 6)
        {

            Console.WriteLine("Menu Options:\n" +
                              "  1. Create sample orders\n" +
                              "  2. Display total cost for each order\n" +
                              "  3. Display packing labels\n" +
                              "  4. Load Goals\n" +
                              "  5. Record Event\n" +
                              "  6. Quit");
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
                                        
                    order.SetCustomerAddress($"{sampleData.GetNextStreet} {random.Next(1, 200)}",
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

                foreach (Order order in orders)
                {
                    decimal totalCost = order.CalculateTotalCost();
                    string customerName = order.GetCustomer().GetCustomerName();
                    Console.WriteLine($"Total cost: {totalCost,7:0.00}$  Customer: {customerName}");
                }

                Console.WriteLine();
            }

            else if (choice == 3)
            {
                Console.WriteLine();
                
                foreach (Order order in orders)
                {
                    string customerName = order.GetCustomer().GetCustomerName();
                    Console.WriteLine($"Customer: {customerName}");
                    Console.WriteLine(order.GetPackingLabel());
                }

                Console.WriteLine();
            }

            else if (choice == 4)
            {

            }

            else if (choice == 5)
            {

            }
        }
    }
}