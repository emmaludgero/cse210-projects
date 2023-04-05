using System;

public class Specific : Goal{

    public Specific (string description, List<string> questionList) : base (description, questionList) {}

    public override void CreateCharacteristic()
    {
        Console.Write($"S -> {_description}");
        Console.WriteLine("\r\n");
        DisplayQuestions();
        
    }
}  