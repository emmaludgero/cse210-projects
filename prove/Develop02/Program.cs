using System;

class Program
{
    static void Main(string[] args)
    {

        do{        
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            int numberChoice = int.Parse(choice);

            if (numberChoice == 1)
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

                
            
                Journal myDay = new Journal();
                myDay._entries.Add(entry);
            } 

            else if (numberChoice == 2)
            {
                Console.Write("Insert the name of the file that you want to open: ");
                string fileName = Console.ReadLine();
                
                
                
            }
            
            else if (numberChoice == 5)
            {
                break;
            }

            
        }  while (true);





        

        
        
    }
}