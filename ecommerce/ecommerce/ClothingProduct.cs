using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class ClothingProduct : Product
{
    private string _size;

    public ClothingProduct(string size, string name, decimal price, int inventory)
        : base(name, price, inventory)
    {
        _size = size;
    }

    public override void AddInventory(int quantity)
    {
        _inventory += quantity;
    }

    public override void RemoveInventory(int quantity)
    {
        _inventory -= quantity;
    }

    public void SetSize(string size)
    {
        _size = size;
    }

    public string GetSize()
    {
        return _size;
    }
}
