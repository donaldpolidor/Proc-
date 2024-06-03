using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Othertown", "CA", "USA");
        Address address3 = new Address("789 Oak St", "Sometown", "TX", "USA");

        // Create events
        Event conference = new Conference("Tech Conference", "A conference about technology.", new DateTime(2024, 11, 3), new DateTime(2023, 11, 3, 9, 0, 0), address1, "Jimmy Duval", 200);
        Event reception = new Reception("Wedding Reception", "A lovely wedding reception.", new DateTime(2024, 12, 5), new DateTime(2023, 12, 5, 18, 0, 0), address2, "weddingreception30@gmail.com");
        Event outdoorGathering = new OutdoorGathering("Picnic", "A fun outdoor picnic.", new DateTime(2024, 8, 20), new DateTime(2023, 8, 20, 12, 0, 0), address3, "Sunny with a chance of showers");

        // Add events to a list
        List<Event> events = new List<Event> { conference, reception, outdoorGathering };

        // Display details for each event
        foreach (Event evt in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine("\nBrief Description:");
            Console.WriteLine(evt.GetBriefDescription());
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
