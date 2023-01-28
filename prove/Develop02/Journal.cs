using System;
using System.IO;
using System.Text;

public class Journal
{
    public List<Entry> _entries = new List<Entry>{};

    public void AddEntry()
    {
        List<string> _prompts = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What make me happy today?", "What could I learn about Jesus today?"};

            Random r = new Random();
            int index = r.Next(_prompts.Count);
            string RandomPrompt = _prompts[index];
            Console.WriteLine(RandomPrompt);

            string response = Console.ReadLine();
            
            var date = DateTime.Now;
            var formattedDate = String.Format("{0:dd/MM/yyyy}", date);

            Entry entry = new Entry();
            entry._date = formattedDate;
            entry._prompt = RandomPrompt;
            entry._response = response;
            
            _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntryDetails();
        }
    }

    public void SaveFile(string fileName)
    {
        
        using (StreamWriter sw = new StreamWriter(fileName))
        foreach (Entry entry in _entries)
        {
            sw.WriteLine("");
            sw.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
            sw.WriteLine($"Response: {entry._response}");
        }      
    }

    public void LoadFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);

        }
    }

}