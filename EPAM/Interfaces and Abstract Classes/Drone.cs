// Create the Drone class that implements IFlyable
public class Drone : IFlyable
{
    private double maxSpeedKmh; // The maximum speed of the drone (in km/h)
    private double hoverTimeMinutes; // The time the drone hovers after every 10 minutes of flight (in minutes)

    // Drone's current position
    public Coordinate CurrentPosition { get; private set; }

    public Drone(double maxSpeedKmh, double hoverTimeMinutes)
    {
        this.maxSpeedKmh = maxSpeedKmh;
        this.hoverTimeMinutes = hoverTimeMinutes;
        // Initialize the drone's position (you can set initial values here)
        CurrentPosition = new Coordinate(0, 0, 0);
    }

    public void FlyTo(Coordinate newPosition)
    {
        // Implement the FlyTo method for Drone
        double distance = CalculateDistance(CurrentPosition, newPosition);

        // Check if the distance to the new position is within the maximum limit
        if (distance > 1000)
        {
            Console.WriteLine("The drone cannot fly to a distance of more than 1000 km.");
            return;
        }

        // Calculate the time taken to fly to the new position
        double timeInHours = distance / maxSpeedKmh;

        // Account for the hovering time
        int hoverCount = (int)(timeInHours * 60 / hoverTimeMinutes);
        timeInHours += hoverCount * hoverTimeMinutes / 60;

        // Update the drone's current position
        CurrentPosition = newPosition;

        Console.WriteLine($"Drone flew to {newPosition.X}, {newPosition.Y}, {newPosition.Z} in {timeInHours} hours.");
    }

    public double GetFlyTime(Coordinate newPosition)
    {
        double distance = CalculateDistance(CurrentPosition, newPosition);
        if (distance > 1000)
        {
            return -1; // Indicate that the distance is not reachable by the drone
        }

        double timeInHours = distance / maxSpeedKmh;
        int hoverCount = (int)(timeInHours * 60 / hoverTimeMinutes);
        timeInHours += hoverCount * hoverTimeMinutes / 60;

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
