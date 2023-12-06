using System.Diagnostics.Contracts;
using System.Runtime;
using System.Text;

public class ChecklistGoal:Goal{

    private int _amountCompleted = 0;
    //if target int amount completed is the same award bonus points in addition to the regular points recieved
    private int _target = 0;
    private int _bonus =0;

    public ChecklistGoal(string name,string description, int points,int target, int bonus):base(name,description,points){
        _amountCompleted = points;
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(){}
    public int  GetAmountPoints(){
        return _amountCompleted;
    }
    public void SetAmountpoints(int points){
        this._amountCompleted = points;
    }
    public int GetTarget(){
        return _target;
    }
    public void SetTarget(int target){
        this._target = target;
    }
    public int GetBonus(){
        return _bonus;
    }
    public void SetBonus(int bonus){
        this._bonus = bonus;
    }
    public override int RecordEvent()
    {   
        _amountCompleted++;
        if (_amountCompleted == _target){
        
        return _bonus + GetPoints();
        }
        else{
            return GetPoints();
        }
    }
    public override string GetDetailsString(){
        
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override bool IsCompleted()
    {
        if(_amountCompleted == _target){
            return true;
        }
        else{
            return false;
        }
    }
    public override string GetStringRepresentation()
    {   
        return $"ChecklistGoal,{base.GetStringRepresentation()},{_amountCompleted},{_target},{_bonus}";
    }

}
