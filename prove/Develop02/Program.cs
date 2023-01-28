using System;
using System.IO;


class Program
{

  static void Main(string[] args)
    {      
        Journal journal1 = new Journal();
            do{ 
                Console.WriteLine("");
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");
                var choice = Console.ReadLine();
                var numberChoice = int.Parse(choice);

                if (numberChoice == 1)
                {
                    journal1.AddEntry();
                }  

                else if (numberChoice == 2)
                {
                    journal1.DisplayEntries();
                }

                else if (numberChoice == 3)
                {
                    Console.WriteLine("What is the filename?");
                    var file = Console.ReadLine();
                    journal1.LoadFile(file);
                }
                
                else if (numberChoice == 4)
                {
                    Console.WriteLine("What is the filename?");
                    var file = Console.ReadLine();
                    journal1.SaveFile(file);
                }

                else if (numberChoice == 5)
                {
                    break;
                }

            }  while (true);    
        
    }
}