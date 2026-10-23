using System;

public class Word
{
    private List<string> _words = new List<string>();

    public Word(string verse)
    {
        string[] splitedVerse = verse.Split(" ");
        foreach (string word in splitedVerse)
        {
            _words.Add(word);
        }
    }

    public void Hide()
    {
        var random = new Random();
        int index = random.Next(_words.Count);
        while (_words[index].StartsWith("_"))
        {
            index = random.Next(_words.Count);   // try again
        }

        _words[index] = new string('_', _words[index].Length);
    }

    public void DisplayWords(string reference)
    {
        Console.Write($"{reference} ");
        foreach (string word in _words)
            Console.Write($"{word} ");
    }

}