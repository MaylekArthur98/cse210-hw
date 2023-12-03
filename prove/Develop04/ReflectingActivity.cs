using System.Diagnostics;
using System.Net.Http.Headers;

public class ReflectingActivity: Activity{
    private List<string> _prompts;
    private List<string> _questions;
    Random rnd = new Random();
    public void startUp(){
        this._prompts= new List<string>();
        this._prompts.Add("Think of a time when you stood up for someone else.");  
        this._prompts.Add("Think of a time when you did something really difficult."); 
        this._prompts.Add("Think of a time when you helped someone in need."); 
        this._prompts.Add("Think of a time when you did something truly selfless.");
        this._questions = new List<string>();
        this._questions.Add("Why was this experience meaningful to you?");
        this._questions.Add("Have you ever done anything like this before?");
        this._questions.Add("How did you get started?");
        this._questions.Add("How did you feel when it was complete?");
        this._questions.Add("What made this time different than other times when you were not as successful?");
        this._questions.Add("What is your favorite thing about this experience?");
        this._questions.Add("What could you learn from this experience that applies to other situations?");
        this._questions.Add("What did you learn about yourself through this experience?");
        this._questions.Add("How can you keep this experience in mind in the future?");
    }




    public ReflectingActivity(int duration): base() { 
        setName("Reflection Activity");
        setDescription("This activity will help you reflect on times in your life when you have shown strength and resilience.\n" + 
        "This will help you recognize the power you have and how you can use it in other aspects of your life.");
        setDuration(duration);
        startUp();
    }
    public ReflectingActivity(){
        setName("Reflection Activity");
        setDescription("This activity will help you reflect on times in your life when you have shown strength and resilience.\n" + 
        "This will help you recognize the power you have and how you can use it in other aspects of your life.");
        startUp();
    }
    public void Run(){
        DisplayStartingMessage();
        ShowSpinner(5);
        Console.WriteLine("\r\r Consider the following prompt:");
        Console.Write("---   ");
        DisplayPrompt();
        Console.Write("   ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("\rYou may begin in:");
        ShowCountDown(3);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            DisplayQuestions();
            ShowSpinner(5);
    
        }
        DisplayEndingMessage();
        int duration = GetDuration();
        Console.WriteLine("You have completed another " + duration + " seconds of the Reflecting Activity");
        ShowSpinner(2);
    }
    public string GetRandomPrompt(){
        int RandomChoice = rnd.Next(4);
        return _prompts.ElementAt(RandomChoice);
    }

    public string GetRandomQuestion(){
        int RandomChoice = rnd.Next(9);
        return _questions.ElementAt(RandomChoice);
    }
    public void DisplayPrompt(){
        Console.Write(GetRandomPrompt());
    }
    public void DisplayQuestions(){
        Console.WriteLine(GetRandomQuestion());
    }
}