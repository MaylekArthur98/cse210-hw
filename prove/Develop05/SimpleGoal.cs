using System.Runtime.CompilerServices;
using System.Text;

public class SimpleGoal:Goal{
    private bool _isCompleted;

    
     public SimpleGoal(string name,string description,int points):base(name,description,points){
         this._isCompleted = false;
    }
    public SimpleGoal(){

    }

    



    public override int RecordEvent()
    {
        SetIsCompleted(true);
        return GetPoints();
    }
    public override bool IsCompleted()
    {
        return this._isCompleted; 
    }
    public void SetIsCompleted(bool userinput){
        this._isCompleted = userinput;
    }
    public override string GetStringRepresentation()
    {  
        return $"SimpleGoal,{base.GetStringRepresentation()},{_isCompleted}";
    }


}