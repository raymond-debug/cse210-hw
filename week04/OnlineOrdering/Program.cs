using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - USA Customer
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.50, 2));

        // Order 2 - International Customer
        Address address2 = new Address("15 Market Circle", "Bibiani", "Western North", "Ghana");
        Customer customer2 = new Customer("Raymond Nayel", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Smartphone", "P003", 499.99, 1));
        order2.AddProduct(new Product("Charger", "P004", 19.99, 3));

        // Display Order 1
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}\n");

        // Display Order 2
        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}