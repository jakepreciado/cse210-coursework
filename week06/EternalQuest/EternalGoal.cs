using System;

public class EternalGoal : Goal
{
    private int _recordCount;
    public EternalGoal(string name, string description, int points) : base(name, description, points) 
    {
        _recordCount = 0;
    }

    public override void RecordEvent()
    {
        _recordCount++;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string DisplayGoal()
    {
        return $"Eternal Goal {GetName()} - Amount of times completed: {_recordCount}";        
    }


}