public interface IFlyable
{
    // The FlyTo method sets the new position of the flying object.
    void FlyTo(Coordinate newPosition);

    // The GetFlyTime method calculates the time taken to fly to the new position.
    // The unit of time may vary depending on the object's speed.
    double GetFlyTime(Coordinate newPosition);
}
