using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create instances for each type of activity
        Activity running = new Running(new DateTime(2022, 7, 5), 30, 4.8);
        Activity cycling = new Cycling(new DateTime(2023, 10, 3), 45, 25.0);
        Activity swimming = new Swimming(new DateTime(2024, 11, 7), 30, 20);

        // Add activities to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display the summary of each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
