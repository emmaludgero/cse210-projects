using System;

public class Evaluate : Goal {

    private List<string> _achievements = new List<string>();

    public Evaluate (string description, List<string> achievements) : base (description){
        _achievements = achievements;
    }

    public override void CreateCharacteristic()
    {
        
    }
}