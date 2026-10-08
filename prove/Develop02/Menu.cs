using System;
using System.IO;
using System.Text;
public class Menu
{
    public void DisplayMenu()
    {
        Journal journal = new Journal();
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
                    journal.AddEntry();
                }  

                else if (numberChoice == 2)
                {
                    journal.DisplayEntries();
                }

                else if (numberChoice == 3)
                {
                    Console.WriteLine("What is the filename?");
                    var file = Console.ReadLine();
                    journal.ReadFromFile(file);
                }
                
                else if (numberChoice == 4)
                {
                    Console.WriteLine("What is the filename?");
                    var file = Console.ReadLine();
                    journal.WriteToFile(file);
                }

                else if (numberChoice == 5)
                {
                    break;
                }

            }  while (true);  
    }

    public bool HaveJournal(){
        Console.WriteLine("Do you already have a journal saved? y/n");
        string haveJournal = Console.ReadLine();

        if (haveJournal == "y")
        {
            return true;
        } 
        else
        {
            return false;
        }

    }
}