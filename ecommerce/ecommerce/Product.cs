using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public abstract class Product
{
    private string _name;
    private decimal _price;
    private int _inventory;

    public Product(string name, decimal price, int inventory)
    {
        _name = name;
        _price = price;
        _inventory = inventory;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetPrice(decimal price)
    {
        _price = price;
    }

    public void SetInventory(int inventory)
    {
        _inventory = inventory;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetInventory()
    {
        return _inventory;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    // public abstract void AddInventory(int quantity);
    // public abstract void RemoveInventory(int quantity);
}
