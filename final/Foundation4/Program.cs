using System;

class Program
{
    static void Main(string[] args)
    {
        List<ExceriseAct> exerciseList = new List<ExceriseAct>();
        Running Run = new Running("04 November 2024",120,7.5);
        Swimming swimming = new Swimming("05 December 2023",180,10);
        Cycling cycling = new Cycling("25 June 2024",240,8.7);
        exerciseList.Add(Run);
        exerciseList.Add(swimming);
        exerciseList.Add(cycling);
        foreach(ExceriseAct exercise in exerciseList){
            Console.WriteLine(exercise.GetSummary());
        }

    }
}