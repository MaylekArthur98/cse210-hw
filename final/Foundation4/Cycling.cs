public class Cycling:ExceriseAct{
    public Cycling(){}

    public Cycling(string date, int minutes,double distance):base(date, minutes,distance){
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
        return $"{GetDate()} Stationary Bicycles({GetMinutes()} mins)- Distance {GetDistance()} miles, Speed {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min per mile";
    }
}