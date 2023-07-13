using System;

// CUSTOMER CLASS
// Responsibilities:
// - stores the customer's name, address
// - returns a line of string with the customer's complete details.
public class Customer
{
    // - fields that stores the customer's name, address (Address class type)
    private string _customerName;
    private Address _address;

    // A constructor that receives the customer's name, address (Address class type) and stores it for local use
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    // A method that returns the address for checking.
    public Address GetAddress()
    {
        return _address;
    }

    // A method that returns the customer's address.
    public string GetCustomerAddress()
    {
        return _address.GetAddress();
    }

    // A method that returns the customer's name
    public string GetCustomerName()
    {
        return _customerName;
    }
}