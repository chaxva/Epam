using System;

public class Scooter
{
    public Engine Engine { get; set; }
    public Chassis Chassis { get; set; }
    public Transmission Transmission { get; set; }
    public string Brand { get; set; }
    public int MaxSpeed { get; set; }

    public Scooter(Engine engine, Chassis chassis, Transmission transmission, string brand, int maxSpeed)
    {
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
        Brand = brand;
        MaxSpeed = maxSpeed;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Scooter Information - Brand: {Brand}, Max Speed: {MaxSpeed} km/h");
        Engine.DisplayInfo();
        Chassis.DisplayInfo();
        Transmission.DisplayInfo();
        Console.WriteLine();
    }
}
