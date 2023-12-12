public class Running:ExceriseAct{
    public Running(){}
    public Running(string date, int minutes,double distance):base(date, minutes,distance){
        SetDate(date);
        SetDistance(distance);
        SetMinutes(minutes);
        
    }
    public override  double  GetPace(){ 
        return GetMinutes() / GetDistance();
    }
    public override double GetSpeed(){
        return 60 / GetPace();
    }
    public override string GetSummary(){
        return $"{GetDate()} Running({GetMinutes()} mins)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

}
