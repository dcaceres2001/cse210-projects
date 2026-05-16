using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
   
    public List<Entry> _entries = new List<Entry>();

  
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
            Console.WriteLine();
        }
    }

   
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry.Date.ToShortDateString()} - {entry.Prompt}");
                writer.WriteLine(entry.Response);
                writer.WriteLine();
            }
        }
    }

   
    public void LoadFromFile(string filename)
    {
        _entries.Clear(); 

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split(new[] { " - " }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    DateTime date = DateTime.Parse(parts[0]);
                    string prompt = parts[1];
                    string response = reader.ReadLine();
                    _entries.Add(new Entry(prompt, response) { Date = date });
                }
            }
        }
    }
}
