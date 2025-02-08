public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing Activity", "This activity helps you practice gratitude by reflecting on the good things in your life by listing them out." +
        "\nWhen the timer starts, begin listing people, places, or events that reflect the prompt.")
    { }

    public void Run()
    {
        DisplayStartingMessage();

        List<string> availablePrompts = new List<string>(_prompts);
        Random random = new Random();

        int index = random.Next(availablePrompts.Count);

        Console.WriteLine(availablePrompts[index]);
        availablePrompts.RemoveAt(index);
        ShowCountdown(5);

        List<string> responses = new List<string>();
        int elapsedTime = 0;
        int listItem = 1;
        int totalTime = _time + 5;


        while (elapsedTime < totalTime)
        {
            Console.Write($"{listItem}. ");
            responses.Add(Console.ReadLine());
            listItem += 1;
            elapsedTime += 3;
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        DisplayEndingMessage();
    }
}
