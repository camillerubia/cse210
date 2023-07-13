using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Foundation2 World!");

        // Create customers with their addresses
        // Instantiates both Customer and Address classes, passing in on required parameters for each class.
        // CUSTOMER 1
        Address customerAddress1 = new Address("420 Jackson St", "Albany", "Indiana", "USA");
        Customer customer1 = new Customer("Jessica Pearson", customerAddress1);

        // CUSTOMER 2
        Address customerAddress2 = new Address("191-1136 Okushumbetsu", "Teshikaga-cho Kawakami-gun", "Hokkaido", "Japan");
        Customer customer2 = new Customer("Katrina Bennett", customerAddress2);

        // Create products for the store.
        Product product1 = new Product("Harry Potter 1", "PH01", 10.99);
        Product product2 = new Product("Stickers (5pcs)", "PH02", 5.99);
        Product product3 = new Product("HP Bookmarks (5pcs)", "PH03", 7.49);
        Product product4 = new Product("Harry Potter 1-3", "PH04", 20.75);
        Product product5 = new Product("Harry Potter 4-7", "PH05", 30.25);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1, 2);
        order1.AddProduct(product2, 7);
        order1.AddProduct(product4, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4, 1);
        order2.AddProduct(product5, 1);
        order2.AddProduct(product3, 5);
        order2.AddProduct(product2, 10);      

        // Display packing labels, shipping labels, and total prices for the orders
        Console.WriteLine("============================================");
        Console.WriteLine("\nOrder 1 - Shipping Label:\n");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nPacking Label:");
        order1.GetPackingLabel();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");
        Console.WriteLine("============================================\n");

        Console.WriteLine("============================================");
        Console.WriteLine("\nOrder 2 - Shipping Label:\n");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("\nPacking Label:");
        order2.GetPackingLabel();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
        Console.WriteLine("============================================\n");
    }
}