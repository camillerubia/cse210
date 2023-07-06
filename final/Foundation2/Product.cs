using System; 

public class Product
{
    private string _productName;
    private int _id;
    private double _price;
    private int _quantity;
    private double _totalPrice;
    private string _productDetails;


    public Product (string productName, int id, double price, int quantity)
    {
        _productName = productName;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductDetails()
    {
        return _productDetails = $"{_id} {_productName} - {_quantity}X {_price}";
    }

    public double GetTotalPrice()
    {
        return _totalPrice = _price * _quantity;
    }
}