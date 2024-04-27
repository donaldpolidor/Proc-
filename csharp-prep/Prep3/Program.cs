using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = false;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("Welcome to Guess My Number!");
            
            while (guess != magicNumber)
            {
                Console.Write("Guess the magic number (between 1 and 100): ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} guesses!");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainInput = Console.ReadLine().ToLower();
            playAgain = playAgainInput == "yes" ? true : false;

        } while (playAgain);
    }
}
