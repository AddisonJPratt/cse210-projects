public class CartItem
{
    private string _name;
    private decimal _price;
    private string _size;

    public CartItem(string name, decimal price, string size)
    {
        _name = name;
        _price = price;
        _size = size;
    }

    public string GetName()
    {
        return _name;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public string GetSize()
    {
        return _size;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetPrice(decimal price)
    {
        _price = price;
    }

    public void SetSize(string size)
    {
        _size = size;
    }
}
