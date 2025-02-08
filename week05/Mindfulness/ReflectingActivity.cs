public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
        : base("Reflection Activity", "This activity helps you reflect on times when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int totalTime = _time + 5;
        Random random = new Random();
        List<string> availableQuestions = new List<string>(_questions);

        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        ShowSpinner(5);

        int elapsedTime = 0;
        while (elapsedTime < totalTime)
        {
            int index = random.Next(availableQuestions.Count);

            Console.WriteLine(availableQuestions[index]);
            availableQuestions.RemoveAt(index);

            ShowSpinner(5);
            elapsedTime += 5;
        }

        DisplayEndingMessage();
    }
}
