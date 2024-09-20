using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        // call Radom call
        Random randomGen = new Random();

        // called the randomGen with the Next method that takes in two parmeters
        // Created a variable that's equals the number generator 
        int randomNum = randomGen.Next(1,10);

        Console.Write("Enter a number between 1-10: ");
        int numInput = int.Parse(Console.ReadLine());
        int attempts = 0;

        while (numInput != randomNum)
        {
            Console.Clear();
            attempts ++;
            if (numInput < randomNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }

            numInput = int.Parse(Console.ReadLine());

        } 

        Console.WriteLine("You did it, great job!!");
        Console.WriteLine($"Attempts: {attempts}");

    }
}