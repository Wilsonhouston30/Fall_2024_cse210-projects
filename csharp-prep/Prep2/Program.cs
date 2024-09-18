using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        // Grabbing input from user with Readline
        Console.Clear();
        Console.Write("What is your grade percentage? ");
        int grade= int.Parse(Console.ReadLine());
        string letter_grade = "";
        int sign = grade% 10;
        string grade_sign = "";

        // Converting string from ReadLine into Int by using int.Parse

        if (grade >= 90)
        {
            letter_grade = "A";
        }
        else if (grade >= 80)
        {
            letter_grade = "B";
        }
        else if (grade >=70)
        {
            letter_grade = "C";
        }
        else if (grade >=60)
        {
            letter_grade = "D";
        }
        else
        {
            letter_grade = "F";
        }

        if (sign <=3)
        {
            grade_sign = "-";
        }
        else if (sign >3.1 && sign <6)
        {
            grade_sign = "";
        }
        else
        {
            grade_sign = "+";
        }

        if (grade < 60)
        {
            Console.WriteLine("You need to retake the class");
        }
        else
        {
            Console.WriteLine("You Passed");
        }
        Console.Clear();
        Console.WriteLine($"Grade: {letter_grade}{grade_sign} Percentage: {grade}%");

        
    }
}