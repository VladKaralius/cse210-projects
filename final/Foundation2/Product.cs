public class Product
{
    private string _productName;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string productName, string productId,
        decimal price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName() => _productName;
    public string GetProductId() => _productId;
    public decimal GetPrice() => _price;
    public int GetQuantity() => _quantity;
}