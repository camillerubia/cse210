using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private double _totalCost;
    private string _packingLabel;
    private string _shippingLabel;
    private int _usShipping = 5;
    private int _outsideShipping = 35;
    private string _orderDetails;

    public Order (Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        foreach (Product product in _products)
        {
            _totalCost += product.GetTotalPrice();
        }

        _totalCost += _customer.GetAddress().IsUSA() ? _usShipping : _outsideShipping;

        return _totalCost;
    }

    public void GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(_packingLabel = product.GetProductDetails());
        }
    }

    public string GetShippingLabel()
    {
        return _shippingLabel = _customer.GetCustomerDetails();;
    }

    public string OrderDetails()
    {
        return _orderDetails = $"{_shippingLabel}\n{_packingLabel}\nTotal Cost: {_totalCost}";
    }
}