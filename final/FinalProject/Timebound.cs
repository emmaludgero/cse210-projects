using System;

public class Timebound : Goal {

    private int _periodOfTime;

    public Timebound (string description, List<string> questions) : base (description, questions){}
    
    public override void CreateCharacteristic()
    {
        Console.WriteLine($"T -> {_description}");
        Console.WriteLine("\r\n");
        DisplayQuestions();
    }
}