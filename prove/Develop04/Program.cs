using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breatheActivity= new BreathingActivity();
        ReflectingActivity reflectionActivity = new ReflectingActivity();
        ListeningActivity ListenActivity = new ListeningActivity();
         int UserSelection = 0;
         while (UserSelection != 4){
            Console.Write("");
            Console.WriteLine("Menu Options:\n"+
            "1. Start breathing activity\n"+"2. Start reflecting activity\n"+
            "3. Start listening activty\n"+
            "4. Quit");
            Console.WriteLine("");
            UserSelection = int.Parse(Console.ReadLine());

            if (UserSelection == 1){
                breatheActivity.run();
            }
            else if (UserSelection == 2){
                reflectionActivity.Run();
            }
            else if (UserSelection == 3){
                ListenActivity.Run();
            }
            else{

            }
        }
    }
}