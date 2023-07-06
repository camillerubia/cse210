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

    public Address GetAddress()
    {
        return _address;
    }

    public string GetCustomerDetails()
    {
        _customerDetails = $"{_customerName}\n{_address.GetAddress()}";
        return _customerDetails;
    }
}