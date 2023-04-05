using System;
using System.IO;
using System.Collections.Generic;

public class EcommerceOperations
{
    private List<ClothingProduct> _products = new List<ClothingProduct>();

    private List<ClothingProduct> _cart = new List<ClothingProduct>();

    public EcommerceOperations() { }

    public void AddProduct(ClothingProduct product)
    {
        _products.Add(product);
        SaveInventory();
    }

    public void SaveInventory()
    {
        using (StreamWriter writer = new StreamWriter("inventory.txt"))
        {
            foreach (ClothingProduct product in _products)
            {
                writer.WriteLine(
                    "{0};{1};{2};{3}",
                    product.GetName(),
                    product.GetPrice(),
                    product.GetInventory(),
                    product.GetSize()
                );
            }
        }
    }
}
