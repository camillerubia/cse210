using System;

// ADDRESS CLASS
// Responsibilities:
// - stores the street, city, state/province and country
// - determines if the address is within USA or outside.

public class Address
{
    // Fields to store street, city, state/provincce and country
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    // A constructor that receives street, city, state/province and country as parameters and stores for local use
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // A method that determines if the address is within USA or not, returns true if it is.
    public bool IsUSA()
    {
        bool checker;
        return checker = _country.Contains("USA");
    }
    
    // A method that returns a line of string with all of the complete address details
    public string GetAddress()
    {
        return $"{_street}, {_city}, {_stateProvince}, {_country}";
    }
}