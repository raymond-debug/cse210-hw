using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

   static void Main()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine($"Score: {score}");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Save Goals");
        Console.WriteLine("5. Load Goals");
        Console.WriteLine("6. Quit");
        Console.Write("Choose an option: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1": CreateGoal(); break;
            case "2": ListGoals(); break;
            case "3": RecordEvent(); break;
            case "4": SaveData(); break;
            case "5": LoadData(); break;
            case "6": return;
        }
    }
}

    static void CreateGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string type = Console.ReadLine();

        Console.Write("What is the name of the goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int pts = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                goals.Add(new SimpleGoal(name, desc, pts));
                break;
            case "2":
                goals.Add(new EternalGoal(name, desc, pts));
                break;
            case "3":
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, desc, pts, target, bonus));
                break;
        
        }
    }

    static void ListGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    static void RecordEvent()
{
    ListGoals();

    Console.Write("Which goal did you complete? (Enter number): ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int index))
    {
        index -= 1; // Convert to zero-based index

        if (index >= 0 && index < goals.Count)
        {
            int earned = goals[index].RecordEvent();
            score += earned;
            Console.WriteLine($"You earned {earned} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }

    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
}

    static void SaveData()
    {
    Console.Write("Enter filename to save (e.g., goals.txt): ");
    string filename = Console.ReadLine();

    using (StreamWriter writer = new StreamWriter(filename))
    {
        writer.WriteLine(score);
        foreach (var goal in goals)
        {
            writer.WriteLine(goal.Serialize());
        }
    }

    Console.WriteLine($"Goals saved to {filename}.");
    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
    }
    static void LoadData()
    {
    Console.Write("Enter filename to load (e.g., goals.txt): ");
    string filename = Console.ReadLine();

    if (!File.Exists(filename))
    {
        Console.WriteLine("File not found.");
        Console.ReadLine();
        return;
    }

    goals.Clear();
    var lines = File.ReadAllLines(filename);
    score = int.Parse(lines[0]);

    for (int i = 1; i < lines.Length; i++)
    {
        goals.Add(GoalFactory.Deserialize(lines[i]));
    }

    Console.WriteLine($"Goals loaded from {filename}.");
    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
    }
}