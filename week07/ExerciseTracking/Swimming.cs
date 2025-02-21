public class Swimming : Activity
{
    private int _laps; 
    private const double LapLengthMeters = 50.0;
    private const double MetersToMiles = 0.000621371; 

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * LapLengthMeters * MetersToMiles;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60; 
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} Swimming ({GetMinutes()} min) - Distance: {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile\n";
    }
}
