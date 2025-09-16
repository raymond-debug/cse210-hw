using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade in % ?");
        string grade = Console.ReadLine();
        int score = int.Parse(grade);
        string letter = "";
        string sign = "";
        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        int lastdigit = score % 10;
        if (letter != "A" && letter != "F")
        {
            if (lastdigit >= 7)
            {
                sign = "+";
            }
            else if (lastdigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && lastdigit < 3)
        {
            sign = "-";
        }
        Console.WriteLine($"Your grade is {letter}{sign}");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations!! You passed");
        }
        else
        {
            Console.WriteLine("Try again next time, You can do better");
        }
    }
}