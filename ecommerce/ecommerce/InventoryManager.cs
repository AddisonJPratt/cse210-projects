using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;

public class InventoryManager
{
    private List<ClothingProduct> _inventory = new List<ClothingProduct>();
    private ShoppingCart _cart = new ShoppingCart();

    public InventoryManager()
    {
        LoadInventoryFromFile("inventory.txt");
    }

    public void LoadInventoryFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                string name = parts[0];
                decimal price = Convert.ToDecimal(parts[1]);
                int inventory = Convert.ToInt32(parts[2]);
                string size = parts[3];

                ClothingProduct item = new ClothingProduct(size, name, price, inventory);
                _inventory.Add(item);
            }
            Console.WriteLine("Inventory loaded from file.");
        }
        else
        {
            Console.WriteLine("Inventory file not found. Creating a new file.");
            File.Create(fileName).Close();
        }
    }

    public void AddProduct(string name, decimal price, int inventory, string size)
    {
        ClothingProduct product = new ClothingProduct(size, name, price, inventory);
        _inventory.Add(product);
        EcommerceOperations ecommerceOperations = new EcommerceOperations();
        ecommerceOperations.AddProduct(product);
    }

    public void AddToCart()
    {
        Console.Write("Enter the index number of the item you want to add to your cart: ");
        int index = Convert.ToInt32(Console.ReadLine()) - 1;

        if (index < 0 || index >= _inventory.Count)
        {
            Console.WriteLine("Invalid index number. Please try again.");
            return;
        }

        ClothingProduct cartItem = _inventory[index];

        // add item to cart
        _cart.AddItem(cartItem);

        Console.WriteLine($"Item added to cart: {cartItem.GetName()}");
    }

    public void ViewInventory()
    {
        int index = 1;
        Console.WriteLine("Inventory:");
        foreach (ClothingProduct item in _inventory)
        {
            Console.WriteLine(
                $"{index}: {item.GetName()} | Price: {item.GetPrice():C} | Inventory: {item.GetInventory()} | Size: {item.GetSize()}"
            );
            index++;
        }
        Console.WriteLine();
    }
}
