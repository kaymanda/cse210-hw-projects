using System;

public class Product
{
    private string _name;
    private string _products;
    private double _price;
    private int _quantity;

    public Product(string name, string products, double price, int quantity)
    {
        _name = name;
        _products = products;
        _price = price;
        _quantity = quantity;
    }
    public string GetProductName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _products;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double PriceTotal()
    {
        return _price * _quantity;
    }

}