using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class ShoppingCart
{
    private List<CartItem> _items = new List<CartItem>();

    public void AddItem(ClothingProduct product)
    {
        CartItem item = new CartItem(product.GetName(), product.GetPrice(), product.GetSize());
        _items.Add(item);
    }

    public void PrintCart()
    {
        Console.WriteLine("Shopping Cart:");
        decimal total = 0;

        foreach (CartItem item in _items)
        {
            Console.WriteLine(
                $"{item.GetName()} | Price: {item.GetPrice():C} | Size: {item.GetSize()}"
            );
            total += item.GetPrice();
        }

        Console.WriteLine($"Total: {total:C}");
    }
}
