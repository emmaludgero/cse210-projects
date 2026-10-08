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
            Console.WriteLine("");
            menu.GetJournal();
            menu.DisplayMenu();
        }
        else
        {
            Console.WriteLine("");
            menu.DisplayMenu();
        }
    }
}