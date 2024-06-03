using System;

public abstract class Activity
{
    private DateTime date;
    private int duration; // in minutes

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date.ToShortDateString()} {this.GetType().Name} ({duration} min) - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} km/h, Pace: {GetPace():0.0} min per km";
    }

    protected int GetDuration()
    {
        return duration;
    }
}
