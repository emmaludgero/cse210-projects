using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> _prompts = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What make me happy today?", "What could I learn about Jesus today?"};

        Random r = new Random();
        int index = r.Next(_prompts.Count);
        string RandomPrompt = _prompts[index];
        Console.WriteLine(RandomPrompt);

        string response = Console.ReadLine();
        
        var date = DateTime.Now;
        var formattedDate = String.Format("{0:dd/MM/yyyy}", date);

        Entry entry = new Entry();
        entry._date = formattedDate;
        entry._prompt = RandomPrompt;
        entry._response = response;
        entry.DisplayEntryDetails();
        
        Journal myDay = new Journal();
        myDay._entries.Add(entry);

        myDay.DisplayJournal();
        
    }
}