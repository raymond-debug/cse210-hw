using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do
        {
    
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guessNumber;
            int guessCount = 0;

            Console.WriteLine("I'm thinking of a number between 1 and 100...");

            do
            {
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
                guessCount++;

                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }

            } while (guessNumber != magicNumber);

            Console.Write("Would you like to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing!");
    }
}