using System;


public class Customer
{
    private string _customerName;
    private Address _address;
    private string _customerDetails;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string GetCustomerDetails()
    {
        return _customerDetails;
    }
}