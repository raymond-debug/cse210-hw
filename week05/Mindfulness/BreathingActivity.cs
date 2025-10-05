using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        name = "Breathing Activity";
        description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void RunActivity()
    {
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine();
            AnimateBreath("Breathe in...", 4);  // Quick expansion
            elapsed += 4;

            if (elapsed >= duration) break;

            AnimateBreath("Breathe out...", 6); // Slower release
            elapsed += 6;
        }
    }
    private void AnimateBreath(string message, int seconds)
    {
        Console.WriteLine(message);
        int totalSteps = 10;
        int delay = (seconds * 1000) / totalSteps;

        for (int i = 1; i <= totalSteps; i++)
        {
            string bar = new string('■', i);
            Console.Write($"\r{bar.PadRight(totalSteps)}");
            Thread.Sleep(delay);
        }

        Console.WriteLine(); // Move to next line after animation
    }
}