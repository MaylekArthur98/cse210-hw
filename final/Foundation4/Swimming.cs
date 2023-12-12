public class Swimming: ExceriseAct{
    private double _swimmingLaps;
    public Swimming(){}

    public Swimming(string date, int minutes, double laps):base(){
        _swimmingLaps = laps;
        SetLaps(laps);
        SetDate(date);
        SetMinutes(minutes);
        SetDistance();
        
        
    }
    public void SetLaps(double laps){
        _swimmingLaps = laps;
    }
    public double GetLaps(){
        return _swimmingLaps;
    }
    public override  double  GetPace(){ 
        return GetMinutes() / GetDistance();
    }
    public override double GetSpeed(){
        return 60 / GetPace();
    }

    public void SetDistance()
    {
        this._distance = GetLaps() * 50/1000;
    }
    public override string GetSummary(){
        return $"{GetDate()} Swimming laps({GetMinutes()} mins)- {GetLaps()} laps, Distance {GetDistance()} miles, Speed {GetSpeed():0.00} mph, Pace: {GetPace()} per mile";
    }
}