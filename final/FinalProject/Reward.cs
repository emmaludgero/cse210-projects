using System;

public class Reward : Goal {

    private string _reward;

    public Reward (string description, string reward) : base (description){
        _reward = reward;
    }

    public override void CreateCharacteristic()
    {
        
    }
}