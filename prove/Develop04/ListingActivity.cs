public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing as many items as possible in a certain domain.", 30)
    {
        _prompts = new List<string> { "What are some things you are grateful for?", "List some achievements you are proud of.", "Name people who have positively impacted your life.", "What are your favorite places to visit?" };
    }

    public override void Run()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("Start listing...");

        Console.WriteLine("Prompt: " + GetRandomPrompt());
        ShowSpinner(_duration); // Display spinner animation while user lists items

        Console.WriteLine("End of listing.");
        base.DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
