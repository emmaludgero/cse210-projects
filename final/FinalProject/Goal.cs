using System;

public abstract class Goal{

    protected string _goalName;
    protected string _description;

    protected List<string> _goalAnswers = new List<string>();

    public Goal (string description, string goalName){
        _description = description;
        _goalName = goalName;
    }
    public Goal (string description){
        _description = description;
    }
    public void DisplayFinalGoal() {
        Console.WriteLine($"{_goalName.ToUpper()}:");
        foreach (var item in _goalAnswers)
        {
            Console.WriteLine($"  {item}");
        }
    }

    public abstract void CreateCharacteristic();

    public void ModifySomething(){

    }
}