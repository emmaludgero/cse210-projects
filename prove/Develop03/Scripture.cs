using System;

class Scripture 

{
    private string _verse;

    public Scripture(string verse)
    {
        _verse = verse;
    }

    public void DisplayScripture(string reference)
    {
        Console.WriteLine($"{reference} {_verse}");
    }
}