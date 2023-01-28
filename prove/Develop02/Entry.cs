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
}