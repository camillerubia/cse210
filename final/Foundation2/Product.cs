using System; 

// PRODUCTS CLASS
// Responsibilities:
// - stores the product name, id, price
// - returns each product price and the product details
public class Product
{
    // Fields that stores the product name, id and price.
    private string _productName;
    private string _id;
    private double _price;

    // A constructor that receives the product name, id and price then stores it for local use
    public Product (string productName, string id, double price)
    {
        _productName = productName;
        _id = id;
        _price = price;
    }

    // A method that receives the quantity then returns a line of string as product details
    public string GetProductDetails(int quantity)
    {
        return $"{_id}| {_productName} - {quantity}x ${_price}";
    }

    // A method that returns the price of the product
    public double GetProductPrice()
    {
        return _price;
    }
}