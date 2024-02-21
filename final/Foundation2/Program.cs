using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("Joseph Smith");
        customer.SetAddress("7247 S State St","Sandy", "Utah", "USA");

        Order order = new Order(customer);
        Product product1 = new Product("Book of Mormon", "BoM1790", 10.00, 10);
        Product product2 = new Product("Colored Pencils", "Col84154", 5.00, 10);
        Product product3 = new Product("Notebook", "B87471N", 2.00, 10);

        
        order.PackageLabelDisplay();
        order.ShippingLabel();
        order.DisplayTotal();
        
        Console.WriteLine();

        Customer customer2 = new Customer("Ellie Bingley");
        customer2.SetAddress("72 Chapel Road","London", "London", "UK");

        Order order2 = new Order(customer2);
        Product product21 = new Product("Cetaphil Lotion", "8417513", 8.00, 1);
        Product product22 = new Product("Face Mask", "9445824", 2.00, 3);
        Product product23 = new Product("Pimple Patched", "10548563", 6.00, 2);

        
        order2.PackageLabelDisplay();
        order2.ShippingLabel();
        order2.DisplayTotal();

        
    }

}