using System;

public class Achievable : Goal {

    private List<string> _skills = new List<string>();
    private List<string> _futureSkills = new List<string>();

    public Achievable (string description, List<string> skills, List<string> futureSkills) : base (description) {
        _skills = skills;
        _futureSkills = futureSkills;
    }
    public override void CreateCharacteristic()
    {
        
    }
}