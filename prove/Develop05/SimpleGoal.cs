using System;

public class SimpleGoal : Goal {


    public SimpleGoal (string goalType) {
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

        _isCompleted = false;

        _goalsList.Add(new string[,]
        {
            {_goalType, _goalName, _description, pointsString}
        });
    }

}