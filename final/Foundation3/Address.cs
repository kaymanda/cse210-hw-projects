using System;

public class Address
{
    private string _addressStreet;
    private string _city;
    private string _state;

    public Address(string address, string city, string state)
    {
        _addressStreet = address;
        _city = city;
        _state = state;

    }
    public string GetAddress()
    {
        string addressStreet = ($"Address: {_addressStreet}, {_city}, {_state}");
        return addressStreet;
    }
    //public void SetAddress(string address, string city, string state)
    //{
    //    _addressStreet = address;
    //    _city = city;
    //    _state = state;
    //}
}