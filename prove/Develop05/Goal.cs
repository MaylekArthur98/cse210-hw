using System.Runtime.InteropServices.Marshalling;

public abstract class Goal{
    private string _shortName = "";
    private string _description = "";
    private int  _points = 0;

    public Goal(string name,string description,int points){
        this._shortName = name;
        this._description = description;
        this._points = points;
    }
    public Goal(){

    }
    public string GetShortName(){
        return _shortName;
    }
    public string GetDescription(){
        return _description;
    }
    public int GetPoints(){
        return _points;
    }
    public void SetShortName(string shortName){
        _shortName = shortName;
    }
    public void SetDescription(string description){
        _description = description;
    }
    public void SetPoints(int points){
        _points = points;
    }
    public abstract int RecordEvent();

    public abstract bool IsCompleted();

    public virtual string GetDetailsString(){
        return $"{_shortName} ({_description})";
    }
    public virtual string GetStringRepresentation(){
        return $"{_shortName},{_description},{_points}";
    }
}
