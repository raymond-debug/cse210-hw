public abstract class Goal
{
    protected string name;
    protected string description;
    protected int points;

    public Goal(string name, string description, int points)
    {
        this.name = name;
        this.description = description;
        this.points = points;
    }

    // Called when the user records progress on the goal
    public abstract int RecordEvent();

    // Returns true if the goal is considered complete
    public abstract bool IsComplete();

    // Returns a formatted status string for display
    public abstract string GetStatus();

    // Serializes the goal into a string for saving
    public abstract string Serialize();

    // Accessors for name and description (optional, if needed elsewhere)
    public string GetName() => name;
    public string GetDescription() => description;
    public int GetPoints() => points;
}