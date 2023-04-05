using System;

public class Relevant : Goal {

    private string _importance;

    public Relevant (string description, List<string> questions) : base (description, questions){}

    public override void CreateCharacteristic()
    {
        Console.WriteLine($"R -> {_description}");
        Console.WriteLine("\r\n");
        DisplayQuestions();
    }
}