public class Running : Activity
{
    private double distance; // in kilometers

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / GetDuration()) * 60;
    }

    public override double GetPace()
    {
        return GetDuration() / distance;
    }
}
