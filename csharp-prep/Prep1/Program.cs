using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is: {last_name}, {first_name}");

    }
}