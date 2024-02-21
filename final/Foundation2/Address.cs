using System;
using System.Data;

public class Address
{
    private string _addressStreet;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country)
    {
        _addressStreet = address;
        _city = city;
        _state = state;
        _country = country;

    }
    public string GetAddress()
    {
        string address = $"{_addressStreet}, {_city}, {_state}, {_country}";  
        return address;
    }
    public bool CountryIs()
    {
        bool CountryIs = true;
        if (_country == "USA")
        {
            CountryIs = false;
            return CountryIs;
        }
        else
        {
            return CountryIs;
        }
    }
   // public void SetAddress(string address, string city, string state, string country)
   //{
   //    _addressStreet = address;
   //    _city = city;
   //    _state = state;
   //     _country = country;

    //}
}