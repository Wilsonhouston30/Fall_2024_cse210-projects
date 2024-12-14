public class Listening : Activity
{
    public Listening() : base("Listening Activity", "This activity helps you practice quick thinking and typing.") { }

    public void StartListeningSession()
    {
        DisplayBeginning();
        TimerRequest();

        StartSession((timeLeft) =>
        {
            string prompt = GenerateRandomPrompt();
            Console.WriteLine($"Prompt {prompt}");

            Console.Write(">");
            string userInput = Console.ReadLine(); 
        });
    }

    private string GenerateRandomPrompt()
    {
        string[] prompts = { "Name the people in your life you appreciate", "What items do you value?", "During a zombie appoculups who are you bring in?" };
        Random random = new Random();
        return prompts[random.Next(prompts.Length)];


    }
}