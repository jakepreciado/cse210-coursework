public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity.",
        "This activity is designed and can help to reduce stress, lower your blood pressure, and improve sleep. " +
        "\nClear your mind and focus on the movement of your body as you breathe.")
    {

    }
    public void Run()
    {
        DisplayStartingMessage();
        
        for (int i = 0; i < _time / 10; i++)
        {
            Console.Write("\n\nBreathe in through your nose... ");
            ShowCountDown(4);
            Console.Write("\nHold... ");
            ShowCountDown(7); 
            Console.Write("\nSlowly breathe out through your mouth... ");
            ShowCountDown(8);
        }

        DisplayEndingMessage();
    }
}