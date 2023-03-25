using System;

public class Timebound : Goal {

    private int _periodOfTime;

    public Timebound (string description, int periodOfTime) : base (description){
        _periodOfTime = periodOfTime;
    }
    
    public override void CreateCharacteristic()
    {
        
    }
}