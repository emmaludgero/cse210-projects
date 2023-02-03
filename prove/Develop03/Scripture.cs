using System;

public class Scripture {


    private string _reference;
    private string _singleVerse;
    private List<string> _rangeVerse = new List<string>();

    public Scripture()
    {
        _reference = "John 3:16";
        _singleVerse = "For God so loved the world that He gave His only begotten Son, that whoever believes in Him should not perish but have everlasting life.";
    }

    public Scripture(string reference, string verse)
    {
        _reference = reference;
        _singleVerse = verse;
    }

    private void HideWords()
    {

    }

    private void GetRenderedText()
    {
        
    }

    private void IsCompletelyHidden()
    {

    }


}