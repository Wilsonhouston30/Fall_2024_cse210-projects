using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    protected string _name {get; set;}
    protected string _discription {get; set;}
    protected int _timer {get; set;}

    public Activity(string name, string discription, int timer = 0)  // intiallizes activity with name, discriptiona and timer
    {
        _name = name;
        _discription = discription;
        _timer = timer;
    }

    public void DisplayBeginning()
    {
        Console.WriteLine($"Activity: {_name}");
        Console.WriteLine($"Description: {_discription}");
        Console.WriteLine($"Prepare to begin....");

        Thread.Sleep(5000);
    }

    public void TimerRequest()
    {
        Console.Write("Enter duration you desire: ");
        string intput = Console.ReadLine();


        if (int.TryParse(intput, out int timer) && timer >0 )
        {
            _timer = timer;  
        }
        else 
        {
            Console.WriteLine("Please enter positive number");
            TimerRequest();
        }
    }

    public void StartSession(Action<int> activity)
    {
        Console.WriteLine($"Starting Activity for {_timer}");

        for (int timeleft = _timer; timeleft > 0; timeleft --)
        {
            activity(timeleft);

            Console.WriteLine($"Time remaining: {timeleft}");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("Times Up!");
    }


}