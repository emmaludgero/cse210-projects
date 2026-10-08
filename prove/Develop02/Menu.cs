using System;
using System.IO;
using System.Text;
public class Menu
{
    Journal _journal = new Journal();
    public void DisplayMenu()
    {
        do
        {
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
                _journal.AddEntry();
            }

            else if (numberChoice == 2)
            {
                _journal.DisplayEntries();
            }

            else if (numberChoice == 3)
            {
                Console.WriteLine("What is the filename?");
                var file = Console.ReadLine();
                _journal.ReadFromFile(file);
            }

            else if (numberChoice == 4)
            {
                Console.WriteLine("What is the filename?");
                var file = Console.ReadLine();
                _journal.WriteToFile(file);
            }

            else if (numberChoice == 5)
            {
                break;
            }

        } while (true);
    }

    /* This function will check if the person already have a journal, and return a bool value*/
    public bool HaveJournal()
    {
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
    /* In case the person already have a journal, this function will get that journal and load it.*/
    public string GetJournal()
    {
        Console.WriteLine("What is the filename? ");
        string file = Console.ReadLine();
        _journal.ReadFromFile(file);
        return file;
    }
}