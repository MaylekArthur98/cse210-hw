using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    //DateTime Now = new DateTime();
    public string _date;
    public string _promptText;
    public string _entryText;
    public Entry(){}
    public  Entry(string Prompt, string entryText) {
        DateTime Now = DateTime.Today;
        this._date = Now.ToString("d"); 
        this._promptText = Prompt;
        this._entryText = entryText;
    }
    public void Display()
    {
        Console.WriteLine(this.ToString());
        // Now = DateTime.Today;
        // Console.WriteLine(Now.ToString("d"));
    }
    public override string ToString(){
         
        return $"Date: {_date} - Prompt: {_promptText}\n{_entryText}";      
    }
    public string fileToString(){
        return $"{_date},{_promptText},{_entryText}";
    }
}