using System;

class Program
{
    static void Main(string[] args)
    {
         List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(), 30, 26.2),
            new Cycling(new DateTime(), 30, 120),
            new Swimming(new DateTime(), 30, 2)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}