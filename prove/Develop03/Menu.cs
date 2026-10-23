using System;

class Menu
{
    private List<string> _scriptures = new List<string>();

    public void DisplayMenuLevel()
    {
        Console.WriteLine("Welcome to your Scripture Memorizer!");
        Console.WriteLine("At what level do you want to play? ");
        Console.WriteLine("1. Easy - one word at a time, short scripture");
        Console.WriteLine("2. Medium - two words at a time, medium scripture");
        Console.WriteLine("3. Hard - three words at a time, large scripture");
    }
    public void DisplayMenuChoice()
    {
        int levelChoice = ChooseOption();

        if (levelChoice == 3)
        {
            DisplayLevel3();
        }
        else if (levelChoice == 2)
        {
            DisplayLevel2();
        }
        else
        {
            DisplayLevel1();
        }
    }
    public void DisplayLevel1()
    {
        string shortVerse = "If ye love me, keep my commandments.";
        Scripture scripture = new Scripture(shortVerse);
        Reference reference = new Reference("John", 14, 15);
        string rf = reference.DisplayReference();
        scripture.DisplayScripture(rf);
        Word words = new Word(shortVerse);
        scripture.DisplayScriptureGame(words, rf, 1);
    }
    public void DisplayLevel2()
    {
        string mediumVerse = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(mediumVerse);
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string rf = reference.DisplayBigReference();
        scripture.DisplayScripture(rf);
        Word words = new Word(mediumVerse);
        scripture.DisplayScriptureGame(words, rf, 2);
    }
    public void DisplayLevel3()
    {
        string largeVerse = "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.";
        Scripture scripture = new Scripture(largeVerse);
        Reference reference = new Reference("Helaman", 5, 12);
        string rf = reference.DisplayReference();
        scripture.DisplayScripture(rf);
        Word words = new Word(largeVerse);
        scripture.DisplayScriptureGame(words, rf, 3);
    }
    public int ChooseOption()
    {
        string userString = Console.ReadLine();
        int userInput = int.Parse(userString);
        return userInput;
    }
}
