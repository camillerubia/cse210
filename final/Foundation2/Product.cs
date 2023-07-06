using System; 

public class Product
{
    private string _productName;
    private string _product;
    private int _id;
    private int _price;
    private int _quantity;
    private int _totalPrice;
    private string _productDetails;

    public Product (string name, string product, int id, int price, int quantity)
    {
        _productName = name;
        _product = product;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductDetails()
    {
        return _productDetails;
    }

    public int GetTotalPrice()
    {
        return _totalPrice = _price * _quantity;
    }
}