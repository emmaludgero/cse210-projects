using System;

public abstract class Goal {

    // Attributes
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
    protected List<string[,]> _goalsList = new List<string[,]>();
    

    // Behaviors
    public abstract void SetGoalInfo();

    public void WriteGoals(){

        foreach (var items in _goalsList)
        {
            foreach (var item in items)
            {
                Console.Write(item +", ");
            }
        }
    }

    public void DisplayGoals(){

        foreach (var items in _goalsList)
        {   
            string nameIndex = items[0,1];
            string descriptionIndex = items[0,2];
            int number = 1;              
            Console.WriteLine($"{number}. [ ] {nameIndex} ({descriptionIndex})");
            number += 1;
            
        }
    }

}