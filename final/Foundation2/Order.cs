public class Order {
    
    private Customer _customer;
    private List<Product> _products;
    

    public Order(string customerName) {
       _customer = new Customer(customerName);
       _products = new List<Product>();
    }

    public void SetCustomerAddress(string streetAddress,
        string city, string state, string country)
    {
        _customer.SetAddress(streetAddress, city, state, country);
    }

    public void AddProduct(string productName, string productId,
        decimal price, int quantity)
    {
        Product product = new Product(productName, productId, price, quantity);
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += (decimal)product.GetPrice() * product.GetQuantity();
        }
        return totalCost;
    }
    
    public Customer GetCustomer() => _customer;
    public List<Product> GetProducts() => _products;
}