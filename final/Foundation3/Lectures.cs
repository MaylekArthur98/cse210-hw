using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

public class Lectures:Event{
    private string _speakerName;
    private int _limtCapacity;

    public Lectures(string eventTitle, string description,string date,string time, string address, string speakerName, int limitCapacity):base(eventTitle,description,date,time,address){
        _speakerName = speakerName;
        _limtCapacity = limitCapacity;
        SetEventTitle(eventTitle);
        SetDescription(description);
        SetDate(date);
        SetTime(time);
        SetAddress(address);

    }
    public Lectures(){}
    public string GetSpeakerName(){
        return _speakerName;
    }
    public int GetLimitCapacity(){
        return _limtCapacity;
    }
    public void SetSpeakerName(string speakerName){
        _speakerName = speakerName;
    }
    public void SetLimitCapacity(int limitCapacity){
        _limtCapacity = limitCapacity;
    }
    public void GetFullDetails(){
        Console.WriteLine($"{GetEventTitle()}-- {GetDescription()}\n"
        +$"Guest Speaker: {GetSpeakerName()}\n"
        +$"On {GetDate()}: {GetAddress()} @{GetTime()}, Only {GetLimitCapacity()} seats available.");
    }
    

}