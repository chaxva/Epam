using System;

public class Drone : IFlyable
{
    public Coordinate CurrentPosition { get; private set; }
    private double SpeedKmPerHour;

    public Drone(double initialSpeed)
    {
        // Assumption: Drone's speed is randomly set between 0 and 20 km/h.
        SpeedKmPerHour = initialSpeed;
    }

    public void FlyTo(Coordinate newPosition)
    {
        double distance = CalculateDistance(CurrentPosition, newPosition);
        // Restriction: Drone can't fly a distance of more than 1000 km.
        if (distance > 1000)
        {
            Console.WriteLine("Error: Drone cannot fly a distance of more than 1000 km.");
            return;
        }

        // Hover in the air every 10 minutes of flight for 1 minute.
        int hoverPeriod = (int)(GetFlyTime(newPosition) / 10);
        SpeedKmPerHour = hoverPeriod > 0 ? 0 : 20;

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
