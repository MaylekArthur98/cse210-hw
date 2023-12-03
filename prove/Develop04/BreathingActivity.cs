using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Formats.Asn1;

public class BreathingActivity: Activity
{
    //pass duration into constructor from main userSelection;
    public BreathingActivity(): base(){
        //setDuration(duration);
        setName("Breathing Activity");
        setDescription("This activity will help you relax by walking your through breathing in and out slowly.\n" + 
        "Clear your mind and focus on your breathing.");
    }
    public void run(){
        DisplayStartingMessage();
        Console.WriteLine("\n");
        
        
        int durationActivity = GetDuration();
        int numOfTimesBreathingCycleFitsIntoTheDurationNumber = 0;
        int secondsForoneBreatheInAndOutSession = 8;
        int lastBreatheOutDuration = 0;
        int tempNum = GetDuration();
        
        
        if(durationActivity % secondsForoneBreatheInAndOutSession != 0){
            while (tempNum >= secondsForoneBreatheInAndOutSession){
                tempNum -= secondsForoneBreatheInAndOutSession;
                numOfTimesBreathingCycleFitsIntoTheDurationNumber++;
            }
        lastBreatheOutDuration = durationActivity - (numOfTimesBreathingCycleFitsIntoTheDurationNumber * secondsForoneBreatheInAndOutSession);
        for (int i = 0; i < numOfTimesBreathingCycleFitsIntoTheDurationNumber; i++){
            DisplayBreathCycle();
        }
        BreatheIn();
        ShowCountDown(lastBreatheOutDuration/2);
        BreatheOut();
        ShowCountDown(lastBreatheOutDuration/2);
        }
        else {
            int numberOfReps = durationActivity / secondsForoneBreatheInAndOutSession;
            for (int i = 0; i < numberOfReps; i++){
                DisplayBreathCycle();
            }
        }
        DisplayEndingMessage();
    }

    public void DisplayBreathCycle(){
        BreatheIn();
        ShowCountDown(4);
        BreatheOut();
        ShowCountDown(4);

    }
    
    
    public void BreatheIn(){
        
        Console.Write("\nBreathe in...");
    }
    public void BreatheOut(){
        Console.Write("\nBreathe out...");
}
}   