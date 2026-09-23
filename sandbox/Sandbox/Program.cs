using System;
using System.Runtime.CompilerServices;

class Program
{

    static double AddNumbers(double x, int y)
    {
        return x + y;
    }
    static void Main(string[] args)
    {
        /* Console.WriteLine("Hello Beautiful Girl!!");*/

       /* bool done = false;

        while (! done)
        {
            Console.Write("Are we done (y/n): ");
            done = Console.ReadLine().ToLower() == "y";
        }*/

        /* 
        bool done;
        do
        {
            Console.Write("Are we done (y/n): ");
            done = Console.ReadLine().ToLower() == "y";
        } while (!done);
        */
        /*
        for (int i=0; i<=100;)
        {
            Console.WriteLine($"Your number is {i}");
            Console.Write("Give me a new number to increment: ");
            string input = Console.ReadLine();
            int newNumber = int.Parse(input);
            i += newNumber;
             
        }
        */
        /*
        List<string> myFriends = new List<string> {"Emma", "Ana", "Livia"};
        myFriends.Add("John");
        int howMany = myFriends.Count();
        Console.WriteLine($"You have {howMany} friends");


        foreach(string name in myFriends)
        {
            Console.WriteLine(name);
        }

        */
    }
}