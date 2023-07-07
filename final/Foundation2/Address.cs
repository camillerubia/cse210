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
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsUSA()
    {
        bool checker;
        return checker = _country.Contains("USA");
    }
    
    public string GetAddress()
    {
        return _address = $"{_street}, {_city}, {_stateProvince}, {_country}";
    }
}