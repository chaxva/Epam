using Flyers;
using Iflyable;


namespace ExecutionMethods
{
    public class Excution

    {
        public static void execution()
        {
            Coordinate initialPosition = new Coordinate { X = 0, Y = 0, Z = 0 };
            Coordinate targetPosition = new Coordinate { X = 10, Y = 10, Z = 10 };

            Bird bird = new Bird(initialPosition);
            Airplane airplane = new Airplane(initialPosition);
            Drone drone = new Drone(initialPosition);


            Console.WriteLine($"Bird fly time: {bird.GetFlyTime(targetPosition)} hours");


            Console.WriteLine($"Airplane fly time: {airplane.GetFlyTime(targetPosition)} hours");


            Console.WriteLine($"Drone fly time: {drone.GetFlyTime(targetPosition)} hours");


            Console.ReadLine();
        }
    }

}
