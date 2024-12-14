using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        static int menuDisplay ()
        {
            string [] menu = ["Breathing Activity", "Listening Activity", "Reflecting Activity", "Done"];
            Console.WriteLine("Menu Options:");
            for (int i = 0; i < menu.Length; i++ )
            {
                Console.WriteLine($"    {i+1}.{menu[i]}");
            }
            Console.Write("Select a choice from the menu: ");
            int userinput = Int32.Parse(Console.ReadLine());

            return userinput;


        }

        int userinput = -1;


        Interaction inter = new Interaction(null,null, 0); // intialize interaction outside while loop
    

        while (userinput != 4)
        {
            userinput = menuDisplay();
            

            if (userinput == 1)
            { 
                inter.LoadAnimation();
                
                Breathing breathing1 = new Breathing();
                breathing1.DisplayBeginning();
                breathing1.StartBreathingSesh();
            }
            else if (userinput ==2)
            {
                inter.LoadAnimation();
                Listening listeningActivity = new Listening();
                listeningActivity.StartListeningSession();
            }

        }



    }
}