using System;
using System.Collections.Generic;

namespace OnlineOrdering;
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _isUs;

    public Address(string street, string city, string state, string country, bool isUs)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _isUs = isUs;
    }

    public bool IsUs()
    {
        return _isUs;
    }

    public string GetFullAddress()
    {
        return $"{_street} \n{_city}\n {_state} {_country}";

    }

}


