using System;

public abstract class Goal
{
    protected string _name;
    private string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName() => _name;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    public virtual bool IsComplete() => false;

    public virtual string GetStringRepresentation()
    {
        return $"{this.GetType().Name}|{_name}|{_description}|{_points}";
    }

    public abstract void RecordEvent();
    public abstract string DisplayGoal();
}
