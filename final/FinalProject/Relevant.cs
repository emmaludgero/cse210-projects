using System;

public class Relevant : Goal {

    private string _importance;

    public Relevant (string description, string importance) : base (description){
        _importance = importance;
    }

    public override void CreateCharacteristic()
    {
        
    }
}