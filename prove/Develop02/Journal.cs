using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using System.IO;
public class Journal
{
    public List<Entry> _entry;
    public Journal(){
        _entry = new List<Entry>();
    }
    public void AddEntry(Entry newEntry)
    {
        _entry.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entry){
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
{

    //for each list Entry write line to the output file
    foreach (Entry e in _entry){
        outputFile.WriteLine(e.fileToString());
    }
}
    }
    public void LoadFromFile(string file)
    {
        
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry tempEntry = new Entry();
            tempEntry._date= parts[0];
            tempEntry._promptText= parts[1];
            tempEntry._entryText = parts[2];
            _entry.Add(tempEntry);

        }
    }
}