using System;


public class Measurable : Goal {

    private string _measure;

    public Measurable (string description, List<string> questions) : base (description, questions){

    }

    public override void CreateCharacteristic()
    {
        Console.WriteLine($"M -> {_description}");
        Console.WriteLine("\r\n");
        DisplayQuestions();

    }
}