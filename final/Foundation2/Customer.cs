using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

public class Customer
{
    private string _name;
    private Address _address;
    public Customer() {}
    public Customer(string name, Address address)
    {   
        this._address = address;
        this._name = name;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
    public void  Display()
    {
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"{GetName()} {_address.DisplayAddress()}\n");

    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public bool IsUsa()
    {
        return _address.UsaOrNot();
    }

}