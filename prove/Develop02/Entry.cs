using System;
using System.IO;
using System.Text;

public class Entry 
{   
    public string _response;
    public string _date;
    public string _prompt;
    public void DisplayEntryDetails()
    {
        Console.WriteLine("");
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
    }

    public string CreateFileSystemString()
    {
        string outputString = "";
        outputString = $"{_date}#{_prompt}#{_response}";
        return outputString;
    }

    public void DisplayJournalEntry(string date, string prompt, string response)
    {
        Console.WriteLine("");
        Console.WriteLine($"Date: {date} - Prompt: {prompt}");
        Console.WriteLine($"Response: {response}");
    }
    /* create a fucntion to populate the entries fields with the data I got from the file, and return a new entry.
    return new Entry(date, prompt, entry) static Entry ....
    */
}