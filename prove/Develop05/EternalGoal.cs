using System;

public class EternalGoal : Goal {

    public EternalGoal(string goalType){
        _goalType = goalType;
    }

    public override void SetGoalInfo()
    {
        Console.WriteLine(_nameQuestion);
        _goalName = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine(_descriptionQuestion);
        _description = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine(_pointsQuestion);
        string pointsString  = Console.ReadLine();
        _points = int.Parse(pointsString);
    }
}