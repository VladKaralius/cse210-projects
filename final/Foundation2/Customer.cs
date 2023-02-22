public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName)
    {
        _customerName = customerName;
    }

    public void SetAddress(string streetAddress,
        string city, string state, string country)
    {
        _customerAddress = new Address(streetAddress, city, state, country);
    }

}