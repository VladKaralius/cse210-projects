public class Order {
    
    private Customer _customer;
    private List<Product> _products;
    

    public Order() {
       _customer = new Customer();
       _products = new List<Product>();
    }

    public void SetCustomer()
    {

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