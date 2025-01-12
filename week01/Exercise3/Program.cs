using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int magicNum = int.Parse(magicNumber);

        int guessNum = 0;

        do
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            guessNum = int.Parse(input);

            if (guessNum > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (magicNum != guessNum);
    }
}