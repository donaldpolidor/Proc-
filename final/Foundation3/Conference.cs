public class Conference : Event
{
    private string speaker;
    private int capacity;

    public Conference(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}
