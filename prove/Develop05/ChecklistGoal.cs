using System;

public class ChecklistGoal : Goal {

    

    public ChecklistGoal(string goalType){
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

        Console.WriteLine("");
        Console.WriteLine("How many times this goal need to be accomplished for a bonus? ");
        string timesString  = Console.ReadLine();
        _times = int.Parse(timesString);

        Console.WriteLine("");
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        string bonusString  = Console.ReadLine();
        _bonus = int.Parse(bonusString);

        _goalsList.Add(new string[,]
        {
            {_goalType, _goalName, _description, pointsString, timesString, bonusString}
        });
    }
}