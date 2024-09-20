using System;
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        int squaredNumber = 0;
        // function that display message returns nothing
        void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program");
        }

        // function that request name then returns name
        string PromtUserName()
        {
            Console.Write("What's you name? ");
            string name = Console.ReadLine();
            return name;
        }

        int PromtUserNumber()
        {
            Console.Write("What's your favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        double Computate(double number)
        {
            squaredNumber = (int)Math.Pow(number, 2);
            return squaredNumber;
        }

        void DisplayResult(string name,double squared)
        {
            Console.WriteLine($"Hello {name}. The square of your number is {squared}");
        }

        double Squared = Computate(PromtUserNumber());

        DisplayResult(PromtUserName(), Squared);

    }


}