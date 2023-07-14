using System;

// ADDRESS CLASS
// Responsibilities:
// - stores the street, city,and state/province

public class Address
{
    // Fields to store street, city and state/province
    private string _street;
    private string _city;
    private string _stateProvince;

    // A constructor that receives street, city, and state/province as parameters and stores for local use
    public Address(string street, string city, string stateProvince)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
    }

    // A method that returns a line of string with all of the complete address details
    public string GetAddress()
    {
        return $"{_street}, {_city}, {_stateProvince}";
    }
}