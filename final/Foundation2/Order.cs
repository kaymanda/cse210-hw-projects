using System;

public class Order
{
    public Customer _customer;

    public List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(string name, string products, double price, int quantity)
    {
        _products.Add(new Product(name, products, price, quantity));
    }
    public int GetShipping()
    {
        int cost;
        if(_customer.GetCountry())
        {
            cost = 35;
        }
        else
        {
            cost = 5;
        }

        return cost;
    }
    
    private double TotalCalculated()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.PriceTotal();
        }
        total += GetShipping();
        return total;
    }
    public void PackageLabelDisplay()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine($"Product: {product.GetProductName()}");
            Console.WriteLine($"Product Id: {product.GetProductId}");
            Console.WriteLine($"Quantity: {product.GetQuantity}");
        }
    }
    public void ShippingLabel()
    {
        Console.WriteLine($"Customer: {_customer.GetName()}");
        Console.WriteLine($"Shipped To: {_customer.AddressDisplay()}");
    }
    public void DisplayTotal()
    {
        Console.WriteLine($"Order Total: ${TotalCalculated()}");
    }
    public void SetAddress(string address, string city, string state, string country)
    {
        _customer.SetAddress(address, city, state, country);
    }
    public void AddList(Product product)
    {
        _products.Add(product);
    }

}