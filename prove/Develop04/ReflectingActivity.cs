public class ReflectingActivity : Activity{

    private List<string> _promptList = new List<string>{
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."
    };
    private List<string> _reflectionQuestionsList = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    
    public ReflectingActivity(string acitivityName, string description) : base (acitivityName, description){
    }
    public ReflectingActivity(string acitivityName, string description, List<string> promptList, List<string> reflectionQuestionsList) : base (acitivityName, description)
    {
        _promptList = promptList;
        _reflectionQuestionsList = reflectionQuestionsList;
    }

    public void DisplayRandomPrompt(){
        
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Random random = new Random();
        int index = random.Next(_promptList.Count());
        Console.WriteLine($" --- {_promptList[index]} --- ");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadKey();
    }

    public void DisplayRandomReflectionQuestion(){
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("");
        Console.Write("You may begin in...");
        PausingCountdown();
        Console.WriteLine("");
        int speed = 0;
        do {    

            if (speed != _duration){
                
                Random random = new Random();
                int index = random.Next(_reflectionQuestionsList.Count());
                Console.WriteLine($"> {_reflectionQuestionsList[index]}");
                PausingSpinner("");
                speed += 500;
                
            } else{
                break;
            }

        } while (true); 
    }
}