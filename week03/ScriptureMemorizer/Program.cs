using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("Ether", 12, 27), "And if men come unto me I will show unto them their weakness."),
            new Scripture(new Reference("Moroni", 10, 4), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true.")
        };

        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture randomScripture = scriptures[index];


        while (true)
        {
            Console.Clear();
            Console.WriteLine(randomScripture.GetDisplayText());

            if (randomScripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations, you've successfully removed all words from the scripture.");
                break;
            }

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
            {
                break;
            }

            randomScripture.HideWords(3);
        }
    }
}