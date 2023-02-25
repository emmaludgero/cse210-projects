public class Activity {

    protected string _activityName;
    protected string _description;
    protected int _duration;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
        Console.Write($"How long, in seconds, would you like for your session? (Choose seconds in tens, ex: 10, 20, 30...): ");
        var choice = Console.ReadLine();
        _duration = int.Parse(choice);
        _duration = _duration * 100;
    }

    public void DisplayEndindMessage(){
        
        PausingSpinner("Well done!");
        Console.WriteLine("");
        _duration = _duration / 100;
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
        PausingSpinner("");
    }

    public void PausingSpinner(string message){
        Console.WriteLine(message);
        Console.Write("|");
        Thread.Sleep(700);
        Console.Write("\b \b"); 
        Console.Write("/"); 
        Thread.Sleep(700);
        Console.Write("\b \b");
        Console.Write("-"); 
        Thread.Sleep(700);
        Console.Write("\b \b");
        Console.Write("|"); 
        Thread.Sleep(700);
        Console.Write("\b \b");
        Console.Write("/"); 
        Thread.Sleep(700);
        Console.Write("\b \b");
        Console.Write("-"); 
        Thread.Sleep(700);
        Console.Write("\b \b");
        Console.Write("|"); 
        Thread.Sleep(700);
        Console.Write("\b \b");
        Console.Write("");
    }

    public void PausingCountdown(){
        for (int i = 5; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }





}