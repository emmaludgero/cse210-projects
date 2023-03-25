using System;

public class Specific : Goal{

    protected List<string> _questionList = new List<string>();

    private List<string> _answers = new List<string>();

    public Specific (string description, List<string> questionList, string goalName) : base (description, goalName) {
        _questionList = questionList;
    }

    public override void CreateCharacteristic()
    {
        foreach (var item in _questionList)
        {
            Console.Write(item);
            var answer = Console.ReadLine();
            _answers.Add(answer);
            Console.WriteLine(" ");
        }
        _goalAnswers.AddRange(_answers);
    }
}  