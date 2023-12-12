using System.Diagnostics.Contracts;

public abstract class ExceriseAct{
    private string _date;
    private int _minutes;
    protected double _distance;
    private double _speed;
    private double _pace;
    public ExceriseAct(){}
    public ExceriseAct(string date, int minutes, double distance){
        _date = date;
        _distance = distance;
        _minutes = minutes;
        _speed = GetSpeed();
        _pace = GetPace();
    }
    public int GetMinutes(){
        return _minutes;
    }
    public string GetDate(){
        return _date;
    }
    public virtual void SetPace(){
        _pace = GetPace();
    }
    public virtual void SetSpeed(){
        _speed = GetSpeed();
    }
    public virtual void SetDate(string date){
        _date = date;
    }
    public virtual void SetMinutes(int minutes){
        _minutes = minutes;
    }
    public virtual void SetDistance(double distance){
        _distance = distance;
    }
    public virtual double GetPace(){ 
        return _minutes / _distance;
    }
    public virtual double GetDistance(){
        return _distance;
    }
    public virtual double GetSpeed(){
        return _distance / _minutes * 60;
    }
    public virtual string GetSummary(){
        return "";
    }
}