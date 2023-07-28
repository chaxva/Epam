using System;

class Program
{
    static void Main()
    {
        Bird bird = new Bird(new Random().Next(0, 21));
        Airplane airplane = new Airplane(200);
        Drone drone = new Drone(new Random().Next(0, 21));

        Coordinate targetPosition = new Coordinate(100, 200, 50);

        bird.FlyTo(targetPosition);
        Console.WriteLine($"Bird will take approximately {bird.GetFlyTime(targetPosition):0.##} hours to fly to the target position.");

        airplane.FlyTo(targetPosition);
        Console.WriteLine($"Airplane will take approximately {airplane.GetFlyTime(targetPosition):0.##} hours to fly to the target position.");

        drone.FlyTo(targetPosition);
        Console.WriteLine($"Drone will take approximately {drone.GetFlyTime(targetPosition):0.##} hours to fly to the target position.");

        Console.ReadLine();
    }
}
     aq ragacaa wasashleli 