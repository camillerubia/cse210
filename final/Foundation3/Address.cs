using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _address;

    public Address(string street, string city, string stateProvince)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
    }

    public string GetAddress()
    {
        return _address = $"{_street}, {_city}, {_stateProvince}";
    }
}