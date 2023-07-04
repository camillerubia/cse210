using System;


public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;
    private string _address;


    public Address(string street, string city, string stateProvince, string country)
    {

    }

    public string GetAddress()
    {
        return _address;
    }
}