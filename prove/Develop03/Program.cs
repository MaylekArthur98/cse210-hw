using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture>_multipleScriptures = new List<Scripture>();
        Random rnd = new Random();
        Reference myReference = new Reference("1 Nephi", 1, 15);
        Scripture newScripture = new Scripture(myReference,"And my father dwelt in a tent");
        Reference myReference2 = new Reference("1 Nephi", 4, 8);
        Scripture newScripture2 = new Scripture(myReference2,"And when I came to him I found that it was Laban");
        Reference myReference3 = new Reference("Omni", 1, 8);
        Scripture newScripture3 = new Scripture(myReference3,"And it came to pass that I did deliver the plates unto my brother Chemish");
        _multipleScriptures.Add(newScripture);
        _multipleScriptures.Add(newScripture2);
        _multipleScriptures.Add(newScripture3);
        Scripture selected = _multipleScriptures.ElementAt(rnd.Next(2));
        
        Console.Write(selected.GetDisplayText());
        Console.WriteLine("\n\nPress enter to continue or type 'quit to finish:");
        var line= "";
        line = Console.ReadLine();
        bool IsCompletelyHidden = false;
        if (line != "quit"){
            while (!IsCompletelyHidden && line != "quit"){
                Console.Clear();
                selected.HideRandomWords(rnd.Next(4));
                Console.Write(selected.GetDisplayText());
                Console.WriteLine("\n\nPress enter to continue or type 'quit to finish:");
                IsCompletelyHidden = selected.IsCompletelyHidden();
                line = Console.ReadLine();
            } 
        }

    }
}