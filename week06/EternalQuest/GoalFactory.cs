public static class GoalFactory
{
    public static Goal Deserialize(string line)
    {
        var parts = line.Split('|');
        switch (parts[0])
        {
            case "Simple":
                return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) { /* set completed */ };
            case "Eternal":
                return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
            case "Checklist":
                return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])) { /* set currentCount */ };
            default:
                throw new Exception("Unknown goal type");
        }
    }
}