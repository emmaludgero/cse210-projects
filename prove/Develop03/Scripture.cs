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

    public void DisplayScriptureGame(Word words, string rf, int count)
    {
        string userInput = "";

        while (userInput != "quit")
        {
            Console.Clear();
            words.DisplayWords(rf);
            Console.WriteLine();
            Console.WriteLine();

            if (words.AllHidden())
            {
                Console.WriteLine("Great job! Every word is hidden.");
                return;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            words.Hide(count);
        }
    }
}