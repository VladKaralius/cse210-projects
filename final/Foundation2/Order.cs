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
        decimal shippingCost;
        if (_customer.IsFromUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        totalCost +=  shippingCost;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalPrice();
        }
                
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Product     Product ID   Qty.\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductName(),-14}{product.GetProductId()}" +
                $"      {product.GetProductQuantity(),3}\n";
        }
        
        return packingLabel;
    }
    
    public Customer GetCustomer() => _customer;
    public List<Product> GetProducts() => _products;
}