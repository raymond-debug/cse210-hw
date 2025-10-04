using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose your difficulty level: Easy / Medium / Hard");
        string difficulty = Console.ReadLine().ToLower();
        int hideCount = difficulty switch
        {
            "easy" => 1,
            "medium" => 3,
            "hard" => 5,
            _ => 3 // default to Medium
        };

        var reference = new Reference("Proverbs", "3:5", "6");
        var text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        var scripture = new Scripture(reference, text);

        while (true)
        {
            scripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(hideCount);

            if (scripture.AllWordsHidden())
            {
                scripture.Display();
                Console.WriteLine("\n🎉 All words hidden. Well done!");
                break;
            }
        }
    }
}