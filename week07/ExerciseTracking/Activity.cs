public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public DateTime GetDate()
    {
        DateTime _currentDate = DateTime.Now; 
        return _currentDate;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min) - Distance: {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per mile\n";
    }
}
