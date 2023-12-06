using System.Runtime.InteropServices;
using System.Text;

public class EternalGoal:Goal{

    public EternalGoal(string name,string description, int points):base(name,description,points){

    }
    public EternalGoal(){

    }
    public override int RecordEvent()
    {
        return GetPoints();
    }
    public override bool IsCompleted()
    {
        return false;
    }
    public void SetIsCompleted(){
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{base.GetStringRepresentation()}";
    }

}
