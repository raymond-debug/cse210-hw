using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Display welcome message
        DisplayWelcome();

        // Step 2: Get user's name
        string userName = PromptUserName();

        // Step 3: Get user's favorite number
        int favoriteNumber = PromptUserNumber();

        // Step 4: Square the number
        int squaredNumber = SquareNumber(favoriteNumber);

        // Step 5: Display the result
        DisplayResult(userName, squaredNumber);
    }

    // Function to display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt for and return user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt for and return user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        string input = Console.ReadLine();
        return int.Parse(input);
    }

    // Function to square a number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result
    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}.");
    }
}