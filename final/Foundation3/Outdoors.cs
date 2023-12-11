public class Outdoors:Event{
    private string _trackWeather;
    public Outdoors(string eventTitle, string description,string date,string time, string address,string trackWeather):base(eventTitle,description,date,time,address){
        this._trackWeather = trackWeather;
        SetEventTitle(eventTitle);
        SetDescription(description);
        SetDate(date);
        SetTime(time);
        SetAddress(address);

    }
    public Outdoors(){}

    public void SetTrackWeather(string trackWeather){
        _trackWeather = trackWeather;
    }
    public string GetTrackerWeather(){
        return _trackWeather;
    }
    public void GetFullDetails(){
        Console.WriteLine($"{GetEventTitle()}-- {GetDescription()}\n"
        +$"On {GetDate()}: {GetAddress()} @{GetTime()}.\n"
        +$"Forecast: {GetTrackerWeather()}");
    }
}