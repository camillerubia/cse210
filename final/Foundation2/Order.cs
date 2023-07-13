using System;

public class Order
{
    private List<(Product product, int quantity)> _products; 
    private Customer _customer;
    private double _totalCost;
    private string _packingLabel;
    private string _shippingLabel;
    private int _usShipping = 5;
    private int _outsideShipping = 35;

    public Order (Customer customer)
    {
        _customer = customer;
        _products = new List<(Product product, int quantity)>();
    }

    public void AddProduct(Product product, int quantity)
    {
        _products.Add((product, quantity));
    }

    public double GetTotalPrice()
    {
        _totalCost = 0;
        foreach (var (product, quantity) in _products)
        {
            _totalCost += product.GetProductPrice() * quantity;
        }

        _totalCost += _customer.GetAddress().IsUSA() ? _usShipping : _outsideShipping;

        return Math.Round(_totalCost, 2);
    }

    public string GetShippingLabel()
    {
        return _shippingLabel = _customer.GetCustomerDetails();;
    }

    public void GetPackingLabel()
    {
        foreach (var (product, quantity) in _products)
        {
            Console.WriteLine(_packingLabel = product.GetProductDetails(quantity));
        }
    }
}