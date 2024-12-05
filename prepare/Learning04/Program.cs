using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignments assignments1 = new Assignments("Maisyn Houston", "Math");
        Console.WriteLine(assignments1.GetSummary());
        Console.WriteLine();


        MathAssignments assignments2 = new MathAssignments("7.3","7-10","Wilson Houston", "Math");
        Console.WriteLine(assignments2.GetSummary());
        Console.WriteLine(assignments2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignments assignments3 = new WritingAssignments("Malachi Houston","Writing","The Mummy Reborn");
        Console.WriteLine(assignments3.GetSummary());
        Console.WriteLine(assignments3.GetWrittingInfo());
    }
}