public class Prompt
{
    public List<string> _prompts = new List<string>()
    {
        "What are three things you're grateful for today and why?",
        "Describe a moment recently that made you feel truly happy.",
        "What is one thing you'd like to improve about yourself, and how can you start?",
        "Write about someone who has had a significant impact on your life.",
        "What does your dream day look like from start to finish?",
        "What’s a challenge you overcame recently, and what did you learn from it?",
        "If you could spend an hour with any historical figure, who would it be and why?",
        "Describe a place that makes you feel at peace.",
        "What are your top three priorities for the upcoming week?",
        "If you could give advice to your younger self, what would you say?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        return _prompts[i];
    }
}
