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

    public void Hide(int count)
    {
        var random = new Random();

        for (int i = 0; i < count; i++)
        {
            if (AllHidden())
            {
                return;
            }

            int index = random.Next(_words.Count);
            while (IsHidden(index))
            {
                index = random.Next(_words.Count);
            }

            _words[index] = new string('_', _words[index].Length);
        }
    }
    public bool IsHidden(int index)
    {
        return _words[index].StartsWith("_");
    }
    public bool AllHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (!IsHidden(i))
            {
                return false;
            }
        }

        return true;
    }

    public void DisplayWords(string reference)
    {
        Console.Write($"{reference} ");
        foreach (string word in _words)
            Console.Write($"{word} ");
    }

}