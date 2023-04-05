using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Customer
{
    private string _name;
    private string _email;

    public Customer(string name, string email)
    {
        _name = name;
        _email = email;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetEmail()
    {
        return _email;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetEmail(string email)
    {
        _email = email;
    }
}
