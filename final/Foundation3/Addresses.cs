using System.Runtime.Loader;

public class Address:Event{
    private string _address;

    public Address(string address):base(){
        this._address = address;

    }
    public Address(){}

    public new void  SetAddress(string address){
        _address = address;
    }
    public  new string GetAddress(){
        return _address;
    }
}