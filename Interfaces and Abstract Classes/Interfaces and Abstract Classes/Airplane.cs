using System;

public class Airplane : IFlyable
{
    public Coordinate CurrentPosition { get; private set; }
    private double SpeedKmPerHour;

    public Airplane(double initialSpeed)
    {
        // Assumption: Airplane's initial speed is set to 200 km/h.
        SpeedKmPerHour = initialSpeed;
    }

    public void FlyTo(Coordinate newPosition)
    {
        double distance = CalculateDistance(CurrentPosition, newPosition);
        // Increase the speed by 10 km/h every 10 km of flight.
        if (distance >= 10)
        {
            int speedIncrement = (int)(distance / 10) * 10;
            SpeedKmPerHour += speedIncrement;
        }

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
