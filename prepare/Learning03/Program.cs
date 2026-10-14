using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFraction1 = new Fraction();

        Fraction example1 = new Fraction();
        example1.SetTop(1);
        example1.SetBottom(1);
        example1.GetFractionString();
        Console.WriteLine(example1.GetDecimalValue());

        Fraction example2 = new Fraction(5);
        example2.GetFractionString();
        Console.WriteLine(example2.GetDecimalValue());

        Fraction example3 = new Fraction(3, 4);
        example3.GetFractionString();
        Console.WriteLine(example3.GetDecimalValue());

        Fraction example4 = new Fraction(1, 3);
        example4.GetFractionString();
        Console.WriteLine(example4.GetDecimalValue());

    }
}