using System;

public class OrderItem
{
    private Product _product;
    private int _quantity;
    private decimal _price;

    public OrderItem(Product product, int quantity, decimal price)
    {
        _product = product;
        _quantity = quantity;
        _price = price;
    }
}
