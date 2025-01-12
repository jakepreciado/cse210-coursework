using System;

class Program
{
    static void Main(string[] args)
    {
        {
            DisplayWelcome();

            string userName = PromptUserName();
            int userNumber = PromptUserNumber();

            int squaredNumber = SquareNumber(userNumber);

            DisplayResult(userName, squaredNumber);
        }


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        static int SquareNumber(int num)
        {
            return num * num;
        }

        static void DisplayResult(string name, int squaredNum)
        {
            Console.WriteLine($"{name}, your favorite number squared is: {squaredNum}");
        }
    }
}