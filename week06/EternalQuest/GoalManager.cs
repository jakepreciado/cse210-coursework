using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _playerScore;

    public GoalManager() { }

    public void Start()
    {
        bool start = true;
        while (start)
        {
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            int choice = int.Parse(input);

            if (choice == 1)
            {
                CreateGoal();
            }
            if (choice == 2)
            {
                ListGoalDetails();
            }
            if (choice == 3)
            {
                SaveGoals("goals.txt");
            }
            if (choice == 4)
            {
                LoadGoals();
            }
            if (choice == 5)
            {
                RecordEvent();
            }
            if (choice == 6)
            {
                Console.WriteLine("Keep crushing those goals. Goodbye!");
                break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine("Goals:");
        ListGoalDetails();
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nList of Goal Names:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count <= 0)
        {
            Console.WriteLine("No goals available.");
        }
        else
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.DisplayGoal());
            }
        }
    }

    public void CreateGoal()
    {
        Console.Write("\nEnter Goal Type:\n1. Simple Goal\n2. Checklist Goal\n3. Eternal Goal\n");
        string input = Console.ReadLine();
        int goalChoice = int.Parse(input);

        Console.WriteLine("Enter Goal Name: ");
        var name = Console.ReadLine();

        Console.WriteLine("Enter Goal Description: ");
        var description = Console.ReadLine();

        Console.WriteLine("Enter Points for Goal: ");
        var points = int.Parse(Console.ReadLine());

        if (goalChoice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalChoice == 2)
        {
            Console.WriteLine("Enter Target Count:");
            var targetCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Bonus Points:");
            var bonusPoints = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
        }
        else if (goalChoice == 3)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }

        Console.WriteLine("Goal Created Successfully!");
    }

    public void RecordEvent()
    {
        if (_goals.Count <= 0)
        {
            Console.WriteLine("No goals available.");
        }
        else
        {
            Console.WriteLine("\nEnter the goal name you want to record an event for:");
            var goalName = Console.ReadLine();

            var goal = _goals.Find(g => g.GetName().Equals(goalName, StringComparison.OrdinalIgnoreCase));

            if (goal != null)
            {
                goal.RecordEvent();
                _playerScore += goal.GetPoints();
                Console.WriteLine($"You completed the {goalName} goal!");
            }
            else
            {
                Console.WriteLine("Goal not found.");
            }
        }
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter newFile = new StreamWriter(fileName))
        {
            newFile.WriteLine(_playerScore); 
            foreach (var goal in _goals)
            {
                newFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        string filename = "goals.txt";
        if (!File.Exists(filename))
        {
            Console.WriteLine("No saved goals file found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();

        _playerScore = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split("|");
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2]; 
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                Goal goal = new SimpleGoal( name, description, points);

                if (isComplete)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                int timesRecorded = int.Parse(parts[3]);

                Goal goal = new EternalGoal(name, description, points);
                for (int t = 0; t < timesRecorded; t++)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int bonus = int.Parse(parts[6]);
                int target = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[4]);

                Goal goal = new ChecklistGoal(name, description, points, target, bonus);

                for (int j = 0; j < amountCompleted; j++)
                {
                    goal.RecordEvent();
                }
                if (goal is ChecklistGoal checkListGoal)
                {
                    
                }
                _goals.Add(goal);
            }
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nYour goals file has been loaded successfully!");
        Console.ResetColor();
    }


}




