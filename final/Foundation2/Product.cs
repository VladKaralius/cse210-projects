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

    public decimal GetTotalPrice()
    {
        return (decimal)_price * _quantity;
    }

    public string GetProductName() => _productName;
    public string GetProductId() => _productId;
    public int GetProductQuantity() => _quantity;
}