public class Running : Activity
{
    private double distanceKm;

    public Running(DateTime date, int minutes, double distanceKm)
        : base(date, minutes)
    {
        this.distanceKm = distanceKm;
    }

    public override double GetDistance() => distanceKm;

    public override double GetSpeed() => (distanceKm / GetMinutes()) * 60;

    public override double GetPace() => GetMinutes() / distanceKm;
}