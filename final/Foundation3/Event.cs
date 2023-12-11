using System.ComponentModel;

public class Event{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    public string GetEventTitle(){
        return _eventTitle;
    }
    public string GetDescription(){
        return _description;
    }

    public string GetDate(){
        return _date;
    }
    public string GetTime(){
        return _time;
    }
    public string GetAddress(){
        return _address;
    }
    public void SetEventTitle(string eventTitle){
        _eventTitle = eventTitle;
    }
    public void SetDescription(string description){
        _description = description;
    }
    public void SetDate(string date){
        _date = date;
    }
    public void SetTime(string time){
        _time = time;
    }
    public void SetAddress(string address){
        _address = address;
    }
    public Event(string eventTitle, string description,string date,string time, string address){}
    public Event(){}

    public void StandardDetails(){
        Console.WriteLine($"{GetEventTitle()}-- {GetDescription()}\n"
        +$"On {GetDate()}: {GetAddress()} @{GetTime()}.");
    }

    public void ShortDescription(){
        Console.WriteLine($"{GetEventTitle()}-- {GetDescription()} on {GetDate()}");
    }

    public string FullDetails(){
        return "";
    }

}