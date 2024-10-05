using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMenu()
        {
            string [] options = {"New Entry", "Load Entry", "Save Entry", "Quit" };
            

            for (int i = 0; i < options.Length; i++ )
            {
                Console.WriteLine($"{i}: {options[i]}");
            }
        }

        Console.Clear();
        DisplayMenu();




        
    }
}