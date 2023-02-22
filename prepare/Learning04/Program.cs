using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a.GetSummary());

        MathAssignment m = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(m.GetSummary());
        Console.WriteLine(m.GetHomeworkList());

        WritingAssignment w = new WritingAssignment("The Causes of World War II by Mary Waters", "European History", "Mary Waters");
        Console.WriteLine(w.GetSummary());
        Console.WriteLine(w.GetWritingInformation());

    }
}