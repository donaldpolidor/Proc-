using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Add New Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Exit");

            Console.WriteLine("Please select one of the following choices.");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
                    newEntry._promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(newEntry._promptText);
                    Console.WriteLine("Enter your response:");
                    newEntry._entryText = Console.ReadLine();
                    theJournal.AddEntry(newEntry);
                    break;
                case 2:
                    theJournal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Enter file name to save:");
                    string saveFileName = Console.ReadLine();
                    theJournal.SaveToFile(saveFileName);
                    break;
                case 4:
                    Console.WriteLine("Enter file name to load:");
                    string loadFileName = Console.ReadLine();
                    theJournal.LoadFromFile(loadFileName);
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}
