public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on moments in your life where you have demonstrated strength and resilience.", 30)
    {
        _prompts = new List<string> { "Think of a time when you faced a challenge.", "Recall a moment when you helped someone else.", "Reflect on a situation where you stayed calm under pressure.", "Consider a time when you overcame a fear." };
        _questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done something like this before?", "How did you get started?", "What did you feel once it was finished?", "What made this time different from other times when you were not as successful?", "What do you like about this experience?", "What can you learn from this experience that applies to other situations?", "What have you learned about yourself through this experience?", "How can you keep this experience in mind for the future?" };
    }

    public override void Run()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("Think deeply about the following prompt:");
        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine("Now, reflect on the following questions:");
        foreach (string question in _questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(500); // Pause between questions
        }

        ShowSpinner(_duration); // Display spinner animation while user reflects

        base.DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}