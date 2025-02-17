using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();

        GoalManager goalManager = new GoalManager();

        goalManager.LoadGoals();
        goalManager.DisplayPlayerInfo();

        Console.WriteLine($"\nMenu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
        goalManager.Start();
    }
}

