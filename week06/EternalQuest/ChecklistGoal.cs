using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _currentCount++;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string DisplayGoal()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_name} ({GetDescription()} - Points - {_points}) -- Currently completed: ({_currentCount}/{_targetCount})";
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}|{_currentCount}|{_targetCount}|{_bonusPoints}";
    }
}