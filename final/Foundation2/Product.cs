using System.Runtime.CompilerServices;

public class Product
{
    private string _productName;
    private int _productId;
    private int _price;
    private int _quantity;
    public Product(){}
    public Product(string productName,int id, int price, int quantity)
    {
        _productName = productName;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }
    public string GetProductName()
    {
        return _productName;
    }
    public void SetProductName(string productName)
    {
        _productName = productName;
    }
    public int GetProductId()
    {
        return _productId;
    }
    public void SetProductId(int productId)
    {
        _productId = productId;
    }
    public int GetPrice()
    {
        return _price;
    }
    public void SetPrice(int price)
    {
        _price = price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public int TotalCost()
    {
        return _price * _quantity;
    }
    public void DisplayProductInfo(){
        Console.WriteLine($"Product: {_productName} ID# {_productId},\n" +
        $"Price Per Item: {_price}, Quantity {_quantity}\n");
    }

}