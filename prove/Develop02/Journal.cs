using System;
using System.Collections.Specialized;
using System.IO;

public class Journal
{
    public List<Entry> _entries;
        

        

    public void AddEntry(Entry newEntry)
    {
        string fileName = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] part = line.Split(",");

            string questionPrompt = part[0];
        }
    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string file)
    {
        string fileName = "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
          outputFile.WriteLine("");  
        }
    }

    public void LoadFromFile(string file)
    {
        string fileName = "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
          outputFile.WriteLine("");  
        }

    }

}