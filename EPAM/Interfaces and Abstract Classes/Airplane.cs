// Create the Airplane class that implements IFlyable
public class Airplane : IFlyable
{
    private double initialSpeedKmh; // The initial speed of the airplane (in km/h)
    private double speedIncreasePer10Km; // The speed increase per 10 km of flight (in km/h)

    // Airplane's current position
    public Coordinate CurrentPosition { get; private set; }

    public Airplane(double initialSpeedKmh, double speedIncreasePer10Km)
    {
        this.initialSpeedKmh = initialSpeedKmh;
        this.speedIncreasePer10Km = speedIncreasePer10Km;
        // Initialize the airplane's position (you can set initial values here)
        CurrentPosition = new Coordinate(0, 0, 0);
    }

    public void FlyTo(Coordinate newPosition)
    {
        // Implement the FlyTo method for Airplane
        double distance = CalculateDistance(CurrentPosition, newPosition);

        // Calculate the time taken to fly to the new position
        double timeInHours = CalculateFlyTime(distance);

        // Update the airplane's current position
        CurrentPosition = newPosition;

        Console.WriteLine($"Airplane flew to {newPosition.X}, {newPosition.Y}, {newPosition.Z} in {timeInHours} hours.");
    }

    public double GetFlyTime(Coordinate newPosition)
    {
        double distance = CalculateDistance(CurrentPosition, newPosition);
        return CalculateFlyTime(distance);
    }

    private double CalculateFlyTime(double distance)
    {
        double speedKmh = initialSpeedKmh;
        double timeInHours = 0;

        while (distance > 0)
        {
            double timeToTravel10Km = 10.0 / speedKmh;
            if (distance > 10)
            {
                timeInHours += timeToTravel10Km;
                distance -= 10;
                speedKmh += speedIncreasePer10Km;
            }
            else
            {
                timeInHours += distance / speedKmh;
                distance = 0;
            }
        }

        return timeInHours;
    }

    // Helper method to calculate the distance between two 3D coordinates
    private double CalculateDistance(Coordinate p1, Coordinate p2)
    {
        double dx = p2.X - p1.X;
        double dy = p2.Y - p1.Y;
        double dz = p2.Z - p1.Z;
        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }
}
