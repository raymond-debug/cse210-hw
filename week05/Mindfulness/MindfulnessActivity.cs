using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected string name;
    protected string description;
    protected int duration;

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {name}.");
        Console.WriteLine(description);
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        ShowCountdown(3);
        RunActivity();
        End();
    }

    protected abstract void RunActivity();

    protected void End()
    {
        Console.WriteLine("\nWell done!");
        ShowCountdown(2);
        Console.WriteLine($"You have completed the {name} for {duration} seconds.");
        ShowCountdown(3);
    }

  protected void ShowCountdown(int seconds)
{
    for (int i = seconds; i > 0; i--)
    {
        Console.Write($"\rStarting in: {i} seconds ");
        Thread.Sleep(1000);
    }
    Console.WriteLine("\rLet's begin!           ");
}

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}