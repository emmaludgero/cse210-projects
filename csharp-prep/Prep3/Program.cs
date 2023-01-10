using System;

class Program
{
    static void Main(string[] args)
    {
        string input;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100); 

            int userNumber = 0;
            int times = 0;

            do
            {
            Console.Write($"\r\nWhat is the magic number? ");
            string userGuess = Console.ReadLine();
            userNumber = int.Parse(userGuess);

            times += 1;

            if (userNumber == magicNumber)
            {
                Console.Write($"You guessed it! It took you {times} time(s)");
            }
            else if (userNumber > magicNumber)
            {
                Console.Write("Lower");
            }
            else if (userNumber < magicNumber)
            {
                Console.Write("Higher");
            }
            } while (userNumber != magicNumber);

            Console.Write($"\r\nDo you want to continue? ");
            input = Console.ReadLine();
        } while (input == "yes");
    }
}