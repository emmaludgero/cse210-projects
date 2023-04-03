using System;

class Program
{
    // \r\n cria uma nova linha
    // Link: https://www.wanderlustworker.com/setting-s-m-a-r-t-e-r-goals-7-steps-to-achieving-any-goal/
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Welcome to SMARTER Goals Creator \r\n");
        Console.WriteLine("SMARTER goals mean that your goal will be Specific, Measurable, Achievable, Relevant, Timebound, Evaluated, and Rewarded.\r\n");
        Console.WriteLine("First, let's define your goal name!\r\n");
        Console.Write("What will be your goal name? ");
        var goalName = Console.ReadLine();

        Console.WriteLine("Alright!\r\n");

        string specificDescription = "The more specific you are about your goals, the better and more able you’ll be to accomplish them no matter what method you use.";

        List<string> specificQuestionList = new List<string> {
            "What is the specific goal you want to achieve? ",
            "What more details can you give? "
        };

        Specific specific = new Specific(specificDescription, specificQuestionList, "Specific");
        specific.CreateCharacteristic();
        specific.DisplayFinalGoal();
    }
}