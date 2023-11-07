using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percent? ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >=80 && grade < 90)
        {
             letter = "B";
        }
        else if (grade >=70 && grade < 80)
        {
             letter = "C";
        }
        else if (grade >=60 && grade < 70)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}.");
        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You have Passed!");
        }
        else
        {
            
            Console.WriteLine("You've failed, try again.");
        }
    }
}