using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentageString = Console.ReadLine();
        int percentageNumber = int.Parse(percentageString);

        string letter = "";

        if (percentageNumber >= 90)
        {
            letter = "A";
        }
        else if (percentageNumber >= 80)
        {
            letter = "B";
        }
        else if (percentageNumber >= 70)
        {
            letter = "C";
        }
        else if (percentageNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }        

        Console.WriteLine($"Your letter grade is {letter}");

        if (percentageNumber >= 70)
        {
            Console.WriteLine("Congrats! You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass the course. You will get better next time.");
        }
    }
}