using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> Words;

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ')
                    .Select(w => new Word(w))
                    .ToList();
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        var random = new Random();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(w => w.IsHidden);
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(Reference.ToString());
        Console.WriteLine(string.Join(" ", Words.Select(w => w.GetDisplayText())));
    }
}