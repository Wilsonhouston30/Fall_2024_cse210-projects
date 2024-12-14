public class Breathing : Activity
{
    
    public Breathing() : base ("Breaching Activty", "This acitivy will help you relax") {}



    public void StartBreathingSesh()
    {
        DisplayBeginning();
        TimerRequest();

        int breathingCycle = 0;

        StartSession((timeleft) =>
        {
            if (breathingCycle % 8 < 4)
            {
                Console.WriteLine("Breathe In...");
            }
            else
            {
                Console.WriteLine("Breathe Out...");
            }

            breathingCycle++;
        });
    }
}