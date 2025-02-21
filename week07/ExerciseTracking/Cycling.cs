public class Cycling : Activity
{
    private double _speedKph;

    public Cycling(DateTime date, int duration, double speedKph) : base(date, duration)
    {
        _speedKph = speedKph;
    }

    public override double GetDistance()
    {
        double speedMph = _speedKph * 0.621371; 
        return speedMph * (GetMinutes() / 60.0);
    }

    public override double GetSpeed()
    {
        return _speedKph * 0.621371;
    }

    public override double GetPace()
    {
        return 60.0 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} Cycling ({GetMinutes()} min) - Distance: {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile\n";
    }
}
