using System;

public class Reference {

    private string _book;
    private int _chapter;
    private int _verse;   
    private int _endVerse; 

    public Reference()
    {
        _book = "John";
        _chapter = 3;
        _verse = 16;
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public void DisplayOneVerseReference(){

        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }

    public void DisplayMultiVersesReference(){

        Console.WriteLine($"{_book} {_chapter}:{_verse}-{_endVerse}");
    }

}