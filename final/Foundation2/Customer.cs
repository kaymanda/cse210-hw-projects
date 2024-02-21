using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name)
    {
        _name = name;
        
    }
    public string GetName()
    {
        return _name;
    }
    public bool GetCountry()
    {
        return _address.CountryIs();
    }
    public string AddressDisplay()
    {
        return _address.GetAddress();
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetAddress(string address, string city, string state, string country)
    {
        _address = new Address(address, city, state, country);
    }

}