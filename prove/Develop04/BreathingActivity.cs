public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by performing deep breathing for a certain time.", 10)
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Please focus on your breath.");

        for (int i = 0; i < 5; i++) // Example: 5 cycles of breathing
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4); // 4 seconds to breathe in
            Console.WriteLine("Breathe out...");
            ShowCountDown(4); // 4 seconds to breathe out
        }

        DisplayEndingMessage();
    }
}