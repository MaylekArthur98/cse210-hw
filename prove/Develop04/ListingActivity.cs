using System.Runtime.CompilerServices;
using System.Timers;

public class ListeningActivity: Activity{
    private int _count;
    private List<string>_prompts;
    List<string> userList = new List<string>();
    Random rnd = new Random();
    
    public void startUp(){
        this._prompts = new List<string>();
        this._prompts.Add("Who are people that you appreciate?");
        this._prompts.Add("What are personal strengths of yours?");
        this._prompts.Add("Who are people that you have helped this week?");
        this._prompts.Add("When have you felt the Holy Ghost this month?");
        this._prompts.Add("Who are some of your personal heroes?");
    }
    public ListeningActivity(int duration):base(){
        setName("Listening Activity");
        setDescription("This activity will help you reflect on the good things in your\n" + 
        "life by having you list as many things as you can in a certain area.");
        setDuration(duration);
        startUp();
    }
    public ListeningActivity(){
        setName("Listening Activity");
        setDescription("This activity will help you reflect on the good things in your\n" + 
        "life by having you list as many things as you can in a certain area.");
        startUp();
    }
    public void Run(){
        //display start message
        //prompt user for seconds, use setter for duration. 
        //run countdown and spinner
        //let user type a list of prompts
        //run display end message
        //let program class control next activity/go back to menu.
        DisplayStartingMessage();
        ShowSpinner(3);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.Write($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            userList.Add(Console.ReadLine());
            this._count++;
    
        }
        // double durationDouble = GetDuration();
        // System.Timers.Timer r = new System.Timers.Timer(durationDouble);
        // r.Elapsed += new ElapsedEventHandler(timer_Elapsed);
        // r.Enabled = true;
        // Boolean running = true;
        // while (running) {
        //     GetListFromUser();
        // }
        // r.Enabled = false;

        // void timer_Elapsed(object sender, ElapsedEventArgs e)
        // {
        // running = false;
        // }
        Console.WriteLine("You wrote this many things! "+ this._count);

        DisplayEndingMessage();
    }
    public string GetRandomPrompt(){
        int RandomChoice = rnd.Next(5);
        return _prompts.ElementAt(RandomChoice);
    }
    public List<string>GetListFromUser(){
        userList.Add(Console.ReadLine());
        this._count ++;
        
        return userList;
    }
}