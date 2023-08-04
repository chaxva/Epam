namespace Interfaces_and_Abstract_Classes
{
    public class Execution
    {
        public static void execution(String[] args)
        {

            Bird bird = new Bird(20); // Max speed of the bird is 20 km/h
            Airplane airplane = new Airplane(200, 10); // Initial speed is 200 km/h, increases by 10 km/h every 10 km of flight
            Drone drone = new Drone(30, 1); // Max speed of the drone is 30 km/h, hovers every 1 minute after every 10 minutes of flight

            // Example usage
            Coordinate destination = new Coordinate(100, 200, 50);
            bird.FlyTo(destination);
            airplane.FlyTo(destination);
            drone.FlyTo(destination);
        }
    }
}