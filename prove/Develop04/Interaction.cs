public class Interaction : Activity
{
    private int _loadingTime;

    public Interaction (string name, string description, int timer) 
        : base(name, description, timer)
        {

        }


    public int ReturnLoadTime() // return the time
    {
        return _loadingTime;
    }

    public void LoadAnimation()
    {
        string [] animation = ["[        ]", "[/       ]", "[//      ]", "[///     ]", "[////    ]", "[/////   ]","[//////  ]","[/////// ]","[////////]"];
       foreach (string animations in animation)
       {
            Console.Clear();
            Console.WriteLine($"{animations} ... Loading");
            Thread.Sleep(1000);
       }
       Console.Clear();
       Console.WriteLine("Load Completed");
    }

        public void CountDown()
    {
        Console.WriteLine($"\n Starting {_name}....");
        for (int i = 5; i > 0 ; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}