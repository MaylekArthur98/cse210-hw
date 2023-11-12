using System;
using System.IO.Enumeration;

class Program
{
    
    static void Main(string[] args)
    {
        int UserSelection = 0;
        Journal NewJournal = new Journal();
        PromptGenerator NewPrompts = new PromptGenerator();
        //NewPrompts.DisplayRandomPrompt();
        while (UserSelection != 5){
            Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices:\n"+
            "1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n"+
            "What would you like to do?");
            Console.WriteLine("");
            UserSelection = int.Parse(Console.ReadLine());
            
            if (UserSelection == 1){
                string prompt = NewPrompts.DisplayRandomPrompt();
                Console.WriteLine(prompt);
                string userEntry = Console.ReadLine();
                Entry NewEntry = new Entry(prompt, userEntry);

                NewJournal.AddEntry(NewEntry);
            }
            else if (UserSelection == 2){
                NewJournal.DisplayAll();
            }
            else if (UserSelection== 3){
                Console.Write("What is the name of the file? ");
                string fileName = Console.ReadLine();
                NewJournal.LoadFromFile(fileName);
            }
            else if (UserSelection== 4){
                Console.Write($"What would you like to name the file? ");
                string fileName = Console.ReadLine();
                NewJournal.SaveToFile(fileName);
            }
            else {
                Console.WriteLine("Have a good day!");
            }
        }
    }
}