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

    }
    
    public Customer GetCustomer() => _customer;
    public List<Product> GetProducts() => _products;
}