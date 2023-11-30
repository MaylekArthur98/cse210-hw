
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Activity{
    private string _name = "";
    private string _description = "";
    private int _duration = 0;
    public Activity(string name, string description, int duration){
        this._name = name;
        this._description = description;
        this._duration = duration;
    }

    public  void DisplayStartingMessage(){
        
    }

    public void DisplayEndingMessage(){}

    public  void ShowSpinner(int seconds){}
    public void ShowCountDown(int seconds){}

}