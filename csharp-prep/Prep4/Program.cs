using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        int userNumber = -1;
        int sum = 0;
        Console.Clear();
        Console.WriteLine("Enter a list of numbers, when you are done type 0");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
                sum = sum +userNumber;
            }

        }
        // using sort method to sort from least to greatest
        numbers.Sort();

        // iterate through the list of <int>numbers
        foreach (int number in numbers)
        {
            Console.Write($"{number},");
        }
        Console.WriteLine();

        // max variable will set the iteration at 0 index 
        int max = numbers[^1];



        float average = ((float)sum)/numbers.Count();

        Console.WriteLine($"Sum:{sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Max {max}");
        Console.WriteLine();

        



    }
}