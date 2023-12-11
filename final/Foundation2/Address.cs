using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class Address 
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    
    private string[] states = {"AL","AK","AZ","AR","CA","CO","CT","DE","FL","GA","HI","ID","IL","IN","IA","KS","KY","LA","ME","MD","MA","MI","MN","MS","MO","MT","NE","NV","NH","NJ","NM","NY","NC","ND","OH","OK","OR","PA","RI","SC","SD","TN","TX","UT","VT","VA","WA","WV","WI","WY"};
    public Address(){
        
    }

    public Address(string streetAddress,string city, string stateProvince,string country )
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    public void SetStateProvidence(string stateProvince){
        this._stateProvince = stateProvince;
    }
    public string GetStateProvidence()
    {
        return _stateProvince;
    }

    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetStreetAddress()
    {
        return _streetAddress;
    }
    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public bool UsaOrNot()
    {
        return states.Contains(GetStateProvidence());
    }
    public string DisplayAddress()
    {
        return $"{GetStreetAddress()} {GetCity()}, {GetCountry()}";
    }
}