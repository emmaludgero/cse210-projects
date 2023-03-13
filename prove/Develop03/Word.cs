using System;

public class Word {

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
        string randomWord = _words[index];
        string novaString = randomWord.Replace(randomWord, new string('_', randomWord.Length));
        _words[index] = novaString;
    }

    public void DisplayWords(string reference)
    {   
        Console.Write($"{reference} ");
        foreach (string word in _words)
        Console.Write($"{word} ");
    }

}