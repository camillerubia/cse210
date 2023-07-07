using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Foundation2 World!\n");

        // Create customers
        Address customerAddress1 = new Address("420 Jackson St", "Albany", "Indiana", "USA");
        Customer customer1 = new Customer("Jessica Pearson", customerAddress1);

        Address customerAddress2 = new Address("191-1136 Okushumbetsu", "Teshikaga-cho Kawakami-gun", "Hokkaido", "Japan");
        Customer customer2 = new Customer("Katrina Bennett", customerAddress2);

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
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Order 1 - Packing Label:\n");
        order1.GetPackingLabel();
        Console.WriteLine($"Order 1 - Total Price: ${order1.GetTotalPrice()}");

        Console.WriteLine("\nOrder 1 - Shipping Label:\n");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("---------------------------------\n");

        Console.WriteLine("---------------------------------");
        Console.WriteLine("Order 2 - Packing Label:\n");
        order2.GetPackingLabel();
        Console.WriteLine($"Order 2 - Total Price: ${order2.GetTotalPrice()}");

        Console.WriteLine("\nOrder 2 - Shipping Label:\n");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("---------------------------------\n");
    }
}