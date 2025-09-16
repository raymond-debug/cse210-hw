using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();

        int input;

        
        do
        {
            Console.Write("Enter a number (0 to stop): ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        
        float average = 0;
        if (numbers.Count > 0)
        {
            average = (float)sum / numbers.Count;
        }

    
        int max = int.MinValue;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Maximum: {max}");

        int smallestPositive = numbers
            .Where(n => n > 0)
            .DefaultIfEmpty(-1) 
            .Min();
        if (smallestPositive > 0)
        {
            Console.WriteLine($"Smallest positive number: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }

        numbers.Sort();

        Console.WriteLine("Sorted list:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }



    }
}