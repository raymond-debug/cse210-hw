public class Reference
{
    public string Book { get; private set; }
    public string VerseStart { get; private set; }
    public string VerseEnd { get; private set; }

    public Reference(string book, string verseStart)
    {
        Book = book;
        VerseStart = verseStart;
        VerseEnd = null;
    }

    public Reference(string book, string verseStart, string verseEnd)
    {
        Book = book;
        VerseStart = verseStart;
        VerseEnd = verseEnd;
    }

    public override string ToString()
    {
        return VerseEnd == null ? $"{Book} {VerseStart}" : $"{Book} {VerseStart}-{VerseEnd}";
    }
}