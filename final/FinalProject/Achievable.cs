using System;

public class Achievable : Goal {

    private List<string> _skills = new List<string>();
    private List<string> _futureSkills = new List<string>();

    public Achievable (string description, List<string> questions) : base (description, questions) {}
    public override void CreateCharacteristic()
    {
        Console.WriteLine($"A -> {_description}");
        Console.WriteLine("\r\n");
        DisplayQuestions();
    }
}