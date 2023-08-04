// Define the IFlyable interface
public interface IFlyable
{
    // Method to fly to a new point in 3D space
    void FlyTo(Coordinate newPosition);

    // Method to calculate the time taken to fly to a new point
    double GetFlyTime(Coordinate newPosition);
}
