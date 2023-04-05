using System;

class Program
{
    // \r\n cria uma nova linha
    // Link: https://www.wanderlustworker.com/setting-s-m-a-r-t-e-r-goals-7-steps-to-achieving-any-goal/
    static void Main(string[] args)
    {
        List<Goal> _goalsList = new List<Goal>();

        Console.WriteLine("Hello! Welcome to SMARTER Goals Creator \r\n");
        Console.WriteLine("SMARTER goals mean that your goal will be Specific, Measurable, Achievable, Relevant, Timebound, Evaluated, and Rewarded.\r\n");
        Console.WriteLine("First, let's define your goal name!\r\n");
        Console.Write("What will be your goal name? ");
        var goalName = Console.ReadLine();

        Console.WriteLine("Alright!\r\n");

        // SPECIFIC CHARACTERISTIC 
        string specificDescription = "The more specific you are about your goals, the better and more able you’ll be to accomplish them no matter what method you use.";

        List<string> specificQuestionList = new List<string> {
            "How can you be more specific? ",
            "What more details can you give? "
        };

        Specific specific = new Specific(specificDescription, specificQuestionList);
        specific.CreateCharacteristic();
        _goalsList.Add(specific);

        Console.WriteLine("Okay \r\n");

        // MEASURABLE CHARACTERISTIC
        string measurableDescription = "Now it is time to evaluate how you will take action to measure it.";

        List<string> measurableQuestionList = new List<string> {
            "How will you measure your goal? ",
            "How will you track your progress and know once you have achieved it? "
        };

        Measurable measurable = new Measurable(measurableDescription, measurableQuestionList);
        measurable.CreateCharacteristic();
        _goalsList.Add(measurable);

        Console.WriteLine("Next... \r\n");

        // ACHIEVABLE CHARACTERISTIC 

        string achievableDescription = "Considering how long it will take, potential obstacles, and measurement methods will all help you determine the realistic odds of achieving your set goal.";

        List<string> achievableQuestionList = new List<string> {
            "Can you achieve the Goal? ",
            "What skills do you have? (Ex: determination, virtue) ",
            "What skills will you need to obtain? "
        };

        Achievable achievable = new Achievable(achievableDescription, achievableQuestionList);
        achievable.CreateCharacteristic();
        _goalsList.Add(achievable);

        Console.WriteLine("Now... \r\n");

        // RELEVANT CHARACTERISTIC

        string relevantDescription = "When a goal is relevant, it relates directly to a skill or professional development strategy that you want to improve.";

        List<string> relevantQuestionList = new List<string> {
            "How important is the goal to you? ",
            "Is it relevant to your values and get you towards your purpose? ",
        };

        Relevant relevant = new Relevant(relevantDescription, relevantQuestionList);
        relevant.CreateCharacteristic();
        _goalsList.Add(relevant);

        Console.WriteLine("Now it's time... \r\n");

        string timeDescription = "Time-bound refers to the timeline you set for working toward your goals as well as how long it will take you to meet milestones and achieve your final results.";

        List<string> timeQuestionList = new List<string> {
            "When does this need to happen? ",
            "What is the end-date? ",
            "Why does it need to be timebound? "
        };

        Timebound timebound = new Timebound(timeDescription, timeQuestionList);
        timebound.CreateCharacteristic();
        _goalsList.Add(timebound);

        Console.WriteLine("Let's evaluate... \r\n");
        

        // EVALUATE CHARACTERISTIC

        string evaluateDescription = "This is where we move beyond goal characteristics and into goal interaction. Evaluation is about reviewing and reflecting.";

        List<string> evaluateQuestionList = new List<string> {
            "How did you perform? ",
            "What can you learn? "
        };

        Evaluate evaluate = new Evaluate(evaluateDescription, evaluateQuestionList);
        evaluate.CreateCharacteristic();
        _goalsList.Add(evaluate);

        Console.WriteLine("Congrats! Now let's celebrate! \r\n");

        string rewardDescription = "Rewards help to build sustainable habits. ";

        List<string> rewardQuestionList = new List<string> {
            "When and how will you celebrate? "
        };

        Reward reward = new Reward(rewardDescription, rewardQuestionList);
        reward.CreateCharacteristic();
        _goalsList.Add(reward);

        Console.WriteLine($"\r\nYour goal is: {goalName.ToUpper()}\r\n");


        
        foreach (var characteristic in _goalsList)
        {
            if (characteristic is Specific){
                Console.Write("\r\nS ->");
                foreach (var answer in characteristic._goalAnswers)
                {
                    Console.Write($" {answer};");
                }
                Console.WriteLine("");
            }
            if (characteristic is Measurable){
                Console.Write("\r\nM ->");
                foreach (var answer in characteristic._goalAnswers)
                {
                    Console.Write($" {answer};");
                }
                Console.WriteLine("");
            }
            if (characteristic is Achievable){
                Console.Write("\r\nA ->");
                foreach (var answer in characteristic._goalAnswers)
                {
                    Console.Write($" {answer};");
                }
                Console.WriteLine("");
            }
            if (characteristic is Relevant){
                Console.Write("\r\nR ->");
                foreach (var answer in characteristic._goalAnswers)
                {
                    Console.Write($" {answer};");
                }
                Console.WriteLine("");
            }
            if (characteristic is Timebound){
                Console.Write("\r\nT ->");
                foreach (var answer in characteristic._goalAnswers)
                {
                    Console.Write($" {answer};");
                }
                Console.WriteLine("");
            }
            if (characteristic is Evaluate){
                Console.Write("\r\nE ->");
                foreach (var answer in characteristic._goalAnswers)
                {
                    Console.Write($" {answer};");
                }
                Console.WriteLine("");
            }
            if (characteristic is Reward){
                Console.Write("\r\nR ->");
                foreach (var answer in characteristic._goalAnswers)
                {
                    Console.Write($" {answer};");
                }
                Console.WriteLine("");
            }
        }

        Console.WriteLine("");
        Console.WriteLine("----     S   M   A   R   T   E   R       G   O   A   L     ----");
        Console.WriteLine("");

    }
}