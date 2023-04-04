using System;

public abstract class Goal {

    // Attributes
    // Public attributes because I need to manipulate data inside the Program. And it's hard to use the base class Goal. 
    public string _goalType;
    public string _goalName;
    public string _description;
    public int _points;
    public int _bonus;
    public int _times;
    public int _timesCompleted = 0;
    public bool _isCompleted;
    protected string _nameQuestion = "What is the name of your goal? ";
    protected string _descriptionQuestion = "What is a short description of it? ";
    protected string _pointsQuestion = "What is the amount of points associated with this goal? ";
    
    // Behaviors
    public abstract void SetGoalInfo();
}