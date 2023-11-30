using System.Diagnostics;

public class ReflectingActivity: Activity{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration): base(name,description,duration) { 
        this._prompts = new List<string>(); 
        this._questions = new List<string>();
    }
    public void Run(){

    }
    public string GetRandomPrompt(){
        return "";
    }

    public string GetRandomQuestion(){
        return "";
    }
    public void DisplayPrompt(){

    }
    public void DisplayQuestions(){}
}