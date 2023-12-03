
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Principal;

public class Activity{
    private string _name = "";
    private string _description = "";
    private int _duration = 0;
    public Activity(string name, string description, int duration){
        this._name = name;
        this._description = description;
        this._duration = duration;
    }
    public Activity(){

    }
    public string GetName(){
        return _name;
    }
    public void setName(string name){
        _name = name;
    }
    public string GetDescription(){
        return _description;
    }
    public void setDescription(string description){
        _description = description;
    }
    public int GetDuration(){
        return _duration;
    }
    public void setDuration(int duration){
        _duration = duration;
    }
    public  void DisplayStartingMessage(){
        Console.WriteLine("Welcome to the " + GetName());
        Console.WriteLine("\n \n" + GetDescription());
        Console.WriteLine("\n \nHow long,in seconds, would you like this activity to last?");
        int seconds = int.Parse(Console.ReadLine());
        setDuration(seconds);
        Console.Clear();
        Console.WriteLine("\nGet Ready...");
        ShowSpinner(2);
    }

    public void DisplayEndingMessage(){
        Console.WriteLine("\n\nWell done!");

    }

    public  void ShowSpinner(int seconds){
        int secondsPassed = 0;
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        while (true){
            foreach(string s in animationStrings){
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                secondsPassed++;
                if (secondsPassed >= seconds){
                    Console.Write("\b \b");
                    return;
                }
            }
        }
    }
    public void ShowCountDown(int seconds){
        for (int i = seconds; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}