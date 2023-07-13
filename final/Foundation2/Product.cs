using System; 

public class Product
{
    private string _productName;
    private string _id;
    private double _price;
    private string _productDetails;

    public Product (string productName, string id, double price)
    {
        _productName = productName;
        _id = id;
        _price = price;
    }

    public string GetProductDetails(int quantity)
    {
        return _productDetails = $"{_id}| {_productName} - {quantity}x ${_price}";
    }

    public double GetProductPrice()
    {
        return _price;
    }
}