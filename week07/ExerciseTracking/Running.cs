public class Running : Activity
{
    private double _distance; 

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (GetMinutes() / 60.0); 
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance; 
    }

    public override string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} Running ({GetMinutes()} min) - Distance: {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile\n";
    }
}
