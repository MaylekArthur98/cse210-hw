using System;

class Program
{
    static void Main(string[] args)
    {
        
        Lectures event1 = new Lectures("Learning of Pscyology","Learn all about how the brain learns and keeps information","December 12th, 2023", "12:00pm","123 grain lane. SilverBack PA, 20657","Rick Jordan",65 );
        event1.ShortDescription();
        Console.WriteLine("");
        event1.StandardDetails();
        Console.WriteLine("");
        event1.GetFullDetails();
        Console.WriteLine("");
        Console.WriteLine("");
        Reception event2 = new Reception("Dining With The Simmons","Join us and help raise money for the elderly while eating delicious foods!","December 6th, 2024", "7:00pm","56 E street. Burrowsburg Dc, 58173","ProfessionalMeetingHalls@outlook.com");
        event2.ShortDescription();
        Console.WriteLine("");
        event2.StandardDetails();
        Console.WriteLine("");
        event2.GetFullDetails();
        Console.WriteLine("");
        Console.WriteLine("");
        Outdoors event3 = new Outdoors("Golfing Tn The Hills","We are hosting our annual golfing tournment this weekend on the hills resort. Please join us for a fun time!","June 7th 2025", "6:00am","798 SouthEast St. Hills CA, 28716","Sunny with a chance of meatballs");
        event3.ShortDescription();
        Console.WriteLine("");
        event3.StandardDetails();
        Console.WriteLine("");
        event3.GetFullDetails();
        Console.WriteLine("");

        
        
    }
}