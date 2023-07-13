using System;
using System.Collections.Generic;

// ORDER CLASS
// Responsibilities:
// - contains list of products, customer detail
// - stores the total cost
// - displays the packing and shipping label
// - determines the cost of shipping within or outside US 

public class Order
{
    // A Product list that will store all the items ordered by the customer
    private List<(Product product, int quantity)> _products; 
    // A field that contains customer details (name and address)
    private Customer _customer;
    // Fields that will store the total order cost
    private double _totalCost;
    // Pre-determined values for shipping if customer lives within or outside US
    private int _usShipping = 5;
    private int _outsideShipping = 35;

    // A constructor that receives customer as parameter then stores it for local use
    // Instantiates new list of products everytime an instantiation of class is created
    public Order (Customer customer)
    {
        _customer = customer;
        _products = new List<(Product product, int quantity)>();
    }

    // A method that allows the system to add to the list of product per order
    public void AddProduct(Product product, int quantity)
    {
        _products.Add((product, quantity));
    }

    // A method that determines the total order cost with the shipping fee.
    public double GetTotalPrice()
    {
        // Initializes the cost to zero
        _totalCost = 0;

        // Deconstructs tuple to iterate over the products
        foreach (var (product, quantity) in _products)
        {
            // Gets each product price then multiplies it to quantity then stores as total cost
            _totalCost += product.GetProductPrice() * quantity;
        }

        // Ternary conditional operator to calculate shipping cost based on customer's address
        // then adds the shipping fee accordingly to the total cost
        _totalCost += _customer.GetAddress().IsUSA() ? _usShipping : _outsideShipping;

        // Returns a rounded sum of total cost
        return Math.Round(_totalCost, 2);
    }

    // A method that returns the shipping label
    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress()}";
    }

    // A method that displays the paccking label
    public void GetPackingLabel()
    {
        foreach (var (product, quantity) in _products)
        {
            Console.WriteLine(product.GetProductDetails(quantity));
        }
    }
}