public class ListingActivity : Activity{

    private List<string> _promptList = new List<string>();
    private List<string> _itemsListed = new List<string>();
    
    public ListingActivity(string acitivityName, string description) : base (acitivityName, description){
    }

    public ListingActivity(string acitivityName, string description, List<string> promptList) : base (acitivityName, description)
    {
        _promptList = promptList;
    }

    public void DisplayRandomPrompt(){

    }
    public void AskToListItems(){

    }
    public void DisplayItemsNumber(){

    }


}