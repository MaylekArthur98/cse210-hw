using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.getSummary());
        MathAssigment m1 = new MathAssigment("7.3","8-19","Roberto Rodriguez","Fractions");
        Console.WriteLine(m1.getSummary());
        Console.WriteLine(m1.GetHomeworkList());
        WritingAssignment w1 = new WritingAssignment("Marry Waters", "European History","The Causes of World War II by Mary Waters");
        Console.WriteLine(w1.getSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }

}