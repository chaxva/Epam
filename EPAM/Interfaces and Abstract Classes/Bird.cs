// Create the Bird class that implements IFlyable
public class Bird : IFlyable
{
    private double maxSpeedKmh; // The maximum speed of the bird (in km/h)

    // Bird's current position
    public Coordinate CurrentPosition { get; private set; }

    public Bird(double maxSpeedKmh)
    {
        this.maxSpeedKmh = maxSpeedKmh;
        // Initialize the bird's position (you can set initial values here)
        CurrentPosition = new Coordinate(0, 0, 0);
    }

    public void FlyTo(Coordinate newPosition)
    {
        // Implement the FlyTo method for Bird
        double distance = CalculateDistance(CurrentPosition, newPosition);

        // Calculate the time taken to fly to the new position
        double timeInHours = distance / maxSpeedKmh;

        // Update the bird's current position
        CurrentPosition = newPosition;

        Console.WriteLine($"Bird flew to {newPosition.X}, {newPosition.Y}, {newPosition.Z} in {timeInHours} hours.");
    }

    public double GetFlyTime(Coordinate newPosition)
    {
        double distance = CalculateDistance(CurrentPosition, newPosition);
        return distance / maxSpeedKmh;
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
