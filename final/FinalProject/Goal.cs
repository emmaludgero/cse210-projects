using System;

public abstract class Goal{

    protected string _goalName;
    protected string _description;

    protected List<string> _questions = new List<string>();
    public List<string> _goalAnswers = new List<string>();
    protected List<Goal> _goalsList = new List<Goal>();
    
    public Goal (string description){
        _description = description;
    }
    public Goal (string description, List<string> questions){
        _description = description;
        _questions = questions;
    }
    public void DisplayFinalGoal() {
        Console.WriteLine($"{_goalName.ToUpper()}:");
        foreach (var item in _goalAnswers)
        {
            Console.WriteLine($"  {item}");
        }
    }

    public abstract void CreateCharacteristic();

    public void DisplayQuestions(){

        List<string> _answers = new List<string>();
        foreach (var item in _questions)
        {
            Console.Write(item);
            var answer = Console.ReadLine();
            _answers.Add(answer);
            Console.WriteLine(" ");
        }
        _goalAnswers.AddRange(_answers);
    }
}