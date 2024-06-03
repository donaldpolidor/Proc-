using System;

public class Event
{
    private string title;
    private string description;
    private DateTime date;
    private DateTime time;
    private Address address;

    public Event(string title, string description, DateTime date, DateTime time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToShortTimeString()}\nAddress: {address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails() + $"\nEvent Type: {this.GetType().Name}";
    }

    public string GetBriefDescription()
    {
        return $"Event Type: {this.GetType().Name}, Title: {title}, Date: {date.ToShortDateString()}";
    }
}
