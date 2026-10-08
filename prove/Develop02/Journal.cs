using System;
using System.IO;
using System.Text;

public class Journal
{
    public List<Entry> _entries = new List<Entry> { };

    /*This function adds a new entry in the journal*/
    public void AddEntry()
    {
        List<string> prompts = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What made me happy today?", "What could I learn about Jesus today?" };

        Random r = new Random();
        int index = r.Next(prompts.Count);
        string randomPrompt = prompts[index];
        Console.WriteLine(randomPrompt);

        string response = Console.ReadLine();

        var date = DateTime.Now;
        var formattedDate = String.Format("{0:dd/MM/yyyy}", date);

        Entry entry = new Entry();
        entry._date = formattedDate;
        entry._prompt = randomPrompt;
        entry._response = response;

        _entries.Add(entry);
    }

    /* This function display all the entries if the person selects 2 (before loading a file will only display the current entry)*/
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntryDetails();
        }
    }

    /* This function writes the prompt to the journal file*/
    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString());
            }
        }
    }

    /* This function reads the journal file*/
    public void ReadFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            Entry entry = new Entry();
            entry._date = date;
            entry._prompt = question;
            entry._response = entryText;
            entry.DisplayEntryDetails();
            _entries.Add(entry);
        }
    }
}