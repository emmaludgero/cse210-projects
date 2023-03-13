using System;

class Scripture 

{
    private string _singleVerse;

    private List<string> _words = new List<string>();


    public Scripture(string singleVerse)
    {
        _singleVerse = singleVerse;
    }

    public Scripture()
    {
        _singleVerse = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
    }

    public void DisplayScripture(string reference)
    {
        Console.WriteLine($"{reference} {_singleVerse}");
    }
}