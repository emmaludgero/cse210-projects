using System;
using System.IO;
using System.Text;

public class Entry
{
    public string _response;
    public string _date;
    public string _prompt;

    /*This function display the entry detail with date, the prompt and the user response*/
    public void DisplayEntryDetails()
    {
        Console.WriteLine("");
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
    }

    /* This function creates the correct string to use in a file in the future*/
    public string CreateFileSystemString()
    {
        string outputString = "";
        outputString = $"{_date}#{_prompt}#{_response}";
        return outputString;
    }

    /* This function displays the entries in a nice format*/
    public void DisplayJournalEntry(string date, string prompt, string response)
    {
        Console.WriteLine("");
        Console.WriteLine($"Date: {date} - Prompt: {prompt}");
        Console.WriteLine($"Response: {response}");
    }
}