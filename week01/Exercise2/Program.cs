using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int number = int.Parse(gradePercentage);

        if (number >= 90)
        {
            Console.WriteLine("Your letter grade: A");
        }
        else if (number >= 80)
        {
            Console.WriteLine("Your letter grade: B");
        }
        else if (number >= 70)
        {
            Console.WriteLine("Your letter grade: C");
        }
        else if (number >= 60)
        {
            Console.WriteLine("Your letter grade: D");
        }
        else
        {
            Console.WriteLine("Your letter grade: F");
        }

        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the class");
        }
    }
}