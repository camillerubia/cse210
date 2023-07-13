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

        // Create 5 products for the store.
        // Instantiates Product class each time a product is created, with Product name, ID and price as parameters
        Product product1 = new Product("Harry Potter 1", "PH01", 10.99);
        Product product2 = new Product("Stickers (5)", "PH02", 5.99);
        Product product3 = new Product("HP Bookmarks (5)", "PH03", 7.49);
        Product product4 = new Product("Harry Potter 1-3", "PH04", 20.75);
        Product product5 = new Product("Harry Potter 4-7", "PH05", 30.25);

        // Create list of orders
        List<Order> orders = new List<Order>();

        // Create orders per customer then adds to the internal product list from Order class which receives the product type and the quantity as parameters.
        // ORDER 1
        Order order1 = new Order(customer1);
        order1.AddProduct(product1, 2);
        order1.AddProduct(product2, 7);
        order1.AddProduct(product4, 1);
        orders.Add(order1);

        // ORDER 2
        Order order2 = new Order(customer2);
        order2.AddProduct(product4, 1);
        order2.AddProduct(product5, 1);
        order2.AddProduct(product3, 5);
        order2.AddProduct(product2, 10);   
        orders.Add(order2);   

        // Display packing labels, shipping labels, and total prices for each order
       // Iterate through orders
        foreach (Order order in orders)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("Shipping Label:\n");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine("\nPacking Label:\n");
            order.GetPackingLabel();
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Total Price: ${order.GetTotalPrice().ToString("F2")}");
            Console.WriteLine("==============================================\n");
        }
    }
}