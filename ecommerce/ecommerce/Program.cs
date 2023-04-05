using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        InventoryManager shop = new InventoryManager();
        EcommerceOperations ecommerce = new EcommerceOperations();

        Console.WriteLine("Welcome to the Ecommerce App!");
        Console.WriteLine("1. Add products to Inventory as seller");
        Console.WriteLine("2. Shop products");
        Console.WriteLine("3. View Cart");
        Console.WriteLine("4. Quit");
        Console.Write("Enter a menu option: ");
        string input = Console.ReadLine();

        while (input != "4")
        {
            switch (input)
            {
                case "1":
                    Console.WriteLine("Welcome to the Seller's Portal");
                    shop.ViewInventory();
                    Console.WriteLine("What would you like to add to the store?");
                    Console.WriteLine("");
                    Console.WriteLine("Enter what the name of clothing Item is:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the price of the item:");
                    string p = Console.ReadLine();
                    decimal price = Convert.ToDecimal(p);
                    Console.WriteLine("Enter what the inventory of the product: ");
                    string i = Console.ReadLine();
                    int inventory = Convert.ToInt32(i);
                    Console.WriteLine("Enter what the size of the clothing is: ");
                    string size = Console.ReadLine();
                    shop.AddProduct(name, price, inventory, size);

                    //Add code for adding products
                    break;
                case "2":
                    Console.WriteLine("Below are the products we have in store at the moment");
                    Console.WriteLine("Input item number to add to cart");

                    shop.ViewInventory();

                    shop.AddToCart();
                    // Add code for shopping products
                    break;

                case "3":
                    ShoppingCart cart = new ShoppingCart();
                    cart.PrintCart();

                    break;
                default:
                    Console.WriteLine("Invalid menu option.");
                    break;
            }

            Console.WriteLine("1. Add products to Inventory as seller");
            Console.WriteLine("2. Shop products");
            Console.WriteLine("3. View Cart");
            Console.WriteLine("4. Quit");
            Console.Write("Enter a menu option: ");
            input = Console.ReadLine();
            Console.Clear();
        }
    }
}
