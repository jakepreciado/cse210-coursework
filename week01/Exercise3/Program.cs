using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("I am thinking of a magic number between 1 and 100! Think you can guess it?");
        // string magicNumber = Console.ReadLine();
        // int magicNum = int.Parse(magicNumber);

        int guessNum = 0;

        Random num = new Random();
        int randomNum = num.Next(1, 100);

        do
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            guessNum = int.Parse(input);

            if (guessNum > randomNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNum < randomNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (randomNum != guessNum);
    }
}