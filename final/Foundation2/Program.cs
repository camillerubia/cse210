using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Foundation2 World!");

        // Create customers
        Address customerAddress1 = new Address("123 Main St", "City1", "State1", "USA");
        Customer customer1 = new Customer("John Doe", customerAddress1);

        Address customerAddress2 = new Address("456 Elm St", "City2", "State2", "Canada");
        Customer customer2 = new Customer("Jane Smith", customerAddress2);

        // Create products
        Product product1 = new Product("Product1", "PH001", 10.99, 2);
        Product product2 = new Product("Product2", "PH002", 5.99, 3);
        Product product3 = new Product("Product3", "PH003", 7.49, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display packing labels, shipping labels, and total prices for the orders
        Console.WriteLine("Order 1 - Packing Label:");
        order1.GetPackingLabel();
        Console.WriteLine("Order 1 - Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine("\nOrder 1 - Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        
        Console.WriteLine();

        Console.WriteLine("Order 2 - Packing Label:");
        order2.GetPackingLabel();
        Console.WriteLine("Order 2 - Total Price: $" + order2.GetTotalPrice());

        Console.WriteLine("\nOrder 2 - Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
    }
}