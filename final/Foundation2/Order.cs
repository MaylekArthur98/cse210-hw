using System.Diagnostics.Contracts;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    //private List<Product>_productId;zzzzzzzzzzzzz
    public Order()
    {
        this._products = new List<Product>();

    }
    public void SetCustomer(Customer customer){
        _customer = customer;
    }
    public void AddProdList(Product product){
        _products.Add(product);
    }
    public int TotalCostOrder()
    {   
        int totalPrice = 0;
        int shippingCost = CalculateShipping();
        foreach(Product p in _products){
            totalPrice += p.TotalCost();
        }
        return totalPrice + shippingCost;
    }
    public void PackingLabel()
    {   
        Console.WriteLine("Packing Label:");
        foreach(Product p in _products)
        {
            p.DisplayProductInfo();
        }
        Console.WriteLine($"Shipping cost: ${CalculateShipping()}");
        Console.Write($"Order Cost: ${TotalCostOrder()}");
    }
    public void ShippingLabel()
    { 
        this._customer.Display();
        
    }
    public int CalculateShipping()
    {
            if (this._customer.IsUsa()){
                return 5;
            }
            else 
            {
                return 35;
            }
    }



}