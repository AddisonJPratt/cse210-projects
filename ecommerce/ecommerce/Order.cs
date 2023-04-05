using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Order
{
    private Customer _customer;
    private Product _product;
    private int _quantity;

    public Order(Customer customer, Product product, int quantity)
    {
        _customer = customer;
        _product = product;
        _quantity = quantity;
    }
}
