using System;

public class Order
{
    private List<Product> _products;
    private List<Customer> _customers;
    private int _totalCost;
    private string _packingLabel;
    private string _shippingLabel;
    private int _shippingFee;
    private int _usShipping = 5;
    private int _outsideShipping = 35;
    private string _orderDetails;


    public int ComputeTotalCost()
    {
        return _totalCost;
    }

    public string OrderDetails()
    {
        return _orderDetails;
    }
}