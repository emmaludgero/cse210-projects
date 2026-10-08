using System;
using System.IO;


class Program
{

  static void Main(string[] args)
    {      
        Menu menu = new Menu();
        Console.WriteLine("Welcome to your Journal!");

        bool haveJournal = menu.HaveJournal();
        if (haveJournal == true)
        {
            
        }



        
        menu.DisplayMenu();
    }
}