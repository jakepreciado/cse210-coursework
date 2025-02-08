using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int _time;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_name}");
        Console.WriteLine($"\n{_description}");

        Console.Write("\nHow many seconds would you like your session to be? ");
        _time = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_time} seconds of the {_name}.");
        ShowSpinner(2);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % 4] + "\b");
            Thread.Sleep(250); 
        }
        
        Console.Write(" \b");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\b{i}");
            System.Threading.Thread.Sleep(1000);
        }
        Console.Write("\b ");
    }
}