using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
        

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry prompt in _entries)
        {
            prompt.Display();
        }
    }

    public void SaveToFile(List<Entry> _entries)
    {
        Console.WriteLine("What is the name of the file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
          foreach (Entry promp in _entries)
          {
            outputFile.WriteLine($"{promp._date},{promp._promptText},{promp._entryText}");
          }
        }
    }

    public List<Entry> LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);
        List<Entry> dataEntry = new List<Entry>();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry info = new Entry();

            info._date = parts[0];
            info._promptText = parts[1];
            info._entryText = parts[2];

            dataEntry.Add(info);
        }
        
        return dataEntry;
    }

}