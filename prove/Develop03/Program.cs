using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Create a Scripture instance
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Display the initial scripture text
        Console.WriteLine(scripture.GetDisplayText());

        // Hide words progressively and display again until completely hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.ReadLine(); // Wait for user to press Enter
            Console.Clear();    // Clear the console
            scripture.HideNextWord(); // Hide the next word
            Console.WriteLine(scripture.GetDisplayText()); // Display the updated scripture text
        }

        Console.WriteLine("All words hidden. Press Enter to exit.");
        Console.ReadLine(); // Wait for user to press Enter to exit
    }
}