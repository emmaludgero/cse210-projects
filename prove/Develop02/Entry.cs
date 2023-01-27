using System;

public class Entry 
{   
    public string _response;
    public string _date;
    public string _prompt;
    public void DisplayEntryDetails()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine("");
    }
}