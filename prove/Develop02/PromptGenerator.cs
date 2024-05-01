public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Did you encounter a challenge today? How did you overcome it?",
        "What was the most unexpected thing that happened today?",
        "What was your dominant mood today?",
        "What was your biggest source of motivation today?",
        "What is the most important thing you accomplished today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}