using System;

public class Evaluate : Goal {

    private List<string> _achievements = new List<string>();

    public Evaluate (string description, List<string> questions) : base (description, questions){}

    public override void CreateCharacteristic()
    {
        Console.WriteLine($"E -> {_description}");
        Console.WriteLine("\r\n");
        DisplayQuestions();
    }
}