public class ListingActivity : Activity{

    private List<string> _promptList = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _itemsListed = new List<string>();
    
    public ListingActivity(string acitivityName, string description) : base (acitivityName, description){
    }

    public ListingActivity(string acitivityName, string description, List<string> promptList) : base (acitivityName, description)
    {
        _promptList = promptList;
    }

    public void DisplayRandomPrompt(){
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("");
        Random random = new Random();
        int index = random.Next(_promptList.Count());
        Console.WriteLine($" --- {_promptList[index]} --- ");
        Console.WriteLine("");
        
    }
    public void AskToListItems(){
        
        Console.WriteLine("You may begin in: ");
        PausingCountdown();
        Console.WriteLine("");
        
        int speed = 0;
        do {    
            if (speed < _duration){
                
                Console.Write("> ");
                var item = Console.ReadLine();
                _itemsListed.Add(item);
                speed += 500;
                
            } else{
                break;
            }

        } while (true);
    }

    public void DisplayItemsNumber(){
        int itemsNumber = _itemsListed.Count();
        Console.WriteLine($"You listed {itemsNumber} items!");
    }
}