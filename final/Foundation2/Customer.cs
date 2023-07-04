using System;


public class Customer
{
    private string _customerName;
    private string _address;
    private string _customerDetails;

    public Customer(string customerName, Address address)
    {
        
    }

    public string GetCustomerDetails()
    {
        return _customerDetails;
    }
}