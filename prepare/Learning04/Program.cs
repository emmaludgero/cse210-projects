using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Emma", "Math");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Emma", "Fractions", "3.4", "13-21");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Kath", "Poems", "Machado de Assis");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInfo());
    }
}