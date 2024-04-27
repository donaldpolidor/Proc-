using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their percentage grade
        Console.Write("Enter the percentage grade: ");
        double percentageGrade = Convert.ToDouble(Console.ReadLine());

        // Determine the letter grade
        string letterGrade = "";
        if (percentageGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (percentageGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (percentageGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (percentageGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Check if the user passed the course
        string message = "";
        if (letterGrade != "F")
        {
            message = "Congratulations, you passed the course!";
        }
        else
        {
            message = "You didn't pass this time, but don't get discouraged!";
        }

        // Display the letter grade and the message
        Console.WriteLine("Your letter grade is: " + letterGrade);
        Console.WriteLine(message);

        // Stretch Challenge: Add ability to include a "+" or "-"
        int lastDigit = Convert.ToInt32(percentageGrade.ToString().Substring(percentageGrade.ToString().Length - 1));
        string sign = "";
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Handle special cases of A+ and F+
        if (letterGrade == "A" && sign == "+")
        {
            letterGrade = "A-";
        }
        else if (letterGrade == "F" && sign == "+")
        {
            sign = "";
        }

        // Display the letter grade with the sign
        Console.WriteLine("Your letter grade with sign is: " + letterGrade + sign);
    }
}
