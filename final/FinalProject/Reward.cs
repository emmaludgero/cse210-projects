using System;

public class Reward : Goal {

    private string _reward;

    public Reward (string description, List<string> questions) : base (description, questions){}

    public override void CreateCharacteristic()
    {
        Console.WriteLine($"R -> {_description}");
        Console.WriteLine("\r\n");
        DisplayQuestions();
    }
}