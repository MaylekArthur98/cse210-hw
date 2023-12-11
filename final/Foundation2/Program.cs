using System;

class Program
{
    static void Main(string[] args)
    {   Order johnnyOrder = new Order();
        Customer johnny = new Customer();
        Address johnnyAddress = new Address();
        Product johnnyProduct = new Product();
        johnny.SetAddress(johnnyAddress);
        johnny.SetName("Johnny");
        johnnyAddress.SetStreetAddress("236 Grover Lane.");
        johnnyAddress.SetCity("Hoovervile");
        johnnyAddress.SetCountry("USA");
        johnnyAddress.SetStateProvidence("MD");
        johnnyOrder.SetCustomer(johnny);
        johnnyOrder.ShippingLabel();
        
        johnnyProduct.SetProductName("Carrot");
        johnnyProduct.SetProductId(1435);
        johnnyProduct.SetPrice(5);
        johnnyProduct.SetQuantity(3);
        johnnyProduct.TotalCost();
        johnnyOrder.AddProdList(johnnyProduct);
        
        Product johnnyProduct2 = new Product();
        johnnyProduct2.SetProductName("Chicken");
        johnnyProduct2.SetProductId(2201);
        johnnyProduct2.SetPrice(15);
        johnnyProduct2.SetQuantity(6);
        johnnyProduct2.TotalCost();
        johnnyOrder.AddProdList(johnnyProduct2);

        Product johnnyProduct3= new Product();
        johnnyProduct3.SetProductName("Brussel Sprouts");
        johnnyProduct3.SetProductId(8594);
        johnnyProduct3.SetPrice(3);
        johnnyProduct3.SetQuantity(8);
        johnnyProduct3.TotalCost();
        johnnyOrder.AddProdList(johnnyProduct3);

        johnnyOrder.PackingLabel();
        


        
        
    }
}