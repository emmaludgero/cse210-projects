using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        float number;
        List<float> numbers = new List<float>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        float sum = 0;

        do{
            
            Console.Write("Enter number: ");
            string inputNUmber = Console.ReadLine();
            number = float.Parse(inputNUmber);

            if (number != 0)
            {
                numbers.Add(number);
                sum += number;  
            }
            

        } while (number != 0);

        Console.WriteLine($"The sum is: {sum}");
        float elements = numbers.Count();
        float average = sum / elements;
        Console.WriteLine($"The average is: {average}");
        float largestNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}