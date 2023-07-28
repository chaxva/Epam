using System;

public class Bird : IFlyable
{
    public Coordinate CurrentPosition { get; private set; }
    private double SpeedKmPerHour;

    public Bird(double initialSpeed)
    {
        // Assumption: Bird's speed is randomly set between 0 and 20 km/h.
        SpeedKmPerHour = initialSpeed;
    }

    public void FlyTo(Coordinate newPosition)
    {
        CurrentPosition = newPosition;
    }

    public double GetFlyTime(Coordinate newPosition)
    {
        double distance = CalculateDistance(CurrentPosition, newPosition);
        // Time = Distance / Speed
        return distance / SpeedKmPerHour;
    }

    // Helper method to calculate distance between two coordinates.
    private double CalculateDistance(Coordinate p1, Coordinate p2)
    {
        double dx = p2.X - p1.X;
        double dy = p2.Y - p1.Y;
        double dz = p2.Z - p1.Z;
        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }
}
