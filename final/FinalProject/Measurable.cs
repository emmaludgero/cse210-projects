using System;


public class Measurable : Goal {

    private string _measure;

    public Measurable (string description, string measure) : base (description){
        _measure = measure;
    }

    public override void CreateCharacteristic()
    {
        
    }
}