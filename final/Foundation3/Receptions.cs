public class Reception:Event{
    private string _email;
    public Reception(string eventTitle, string description,string date,string time, string address,string email):base(eventTitle,description,date,time,address){
        this._email = email;
        SetEventTitle(eventTitle);
        SetDescription(description);
        SetDate(date);
        SetTime(time);
        SetAddress(address);
    }

    public void SetEmail(string email){
        _email = email;
    }
    public string GetEmail(){
        return _email;
    }

    public Reception(){}

    public void GetFullDetails(){
        Console.WriteLine($"{GetEventTitle()}-- {GetDescription()}\n"
        +$"You can RSVP by emailing: {GetEmail()}"
        +$"On {GetDate()}: {GetAddress()} @{GetTime()}.");
    }
}