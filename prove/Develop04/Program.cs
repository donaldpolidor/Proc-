using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mindfulness Activities Program!");

        while (true)
        {
            // Show menu
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            // Read user's choice
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            // Execute the activity according to the user's choice
            switch (choice)
            {
                case "1":
                    RunBreathingActivity();
                    break;
                case "2":
                    RunReflectingActivity();
                    break;
                case "3":
                    RunListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using Mindfulness Activities Program!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    static void RunBreathingActivity()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.DisplayStartingMessage();
        breathingActivity.Run();
        breathingActivity.DisplayEndingMessage();
    }

    static void RunReflectingActivity()
    {
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        reflectingActivity.DisplayStartingMessage();
        reflectingActivity.Run();
        reflectingActivity.DisplayEndingMessage();
    }

    static void RunListingActivity()
    {
        ListingActivity listingActivity = new ListingActivity();
        listingActivity.DisplayStartingMessage();
        listingActivity.Run();
        listingActivity.DisplayEndingMessage();
    }
}