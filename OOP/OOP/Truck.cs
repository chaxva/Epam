using System;

public class Truck
{
    public Engine Engine { get; set; }
    public Chassis Chassis { get; set; }
    public Transmission Transmission { get; set; }
    public string Model { get; set; }
    public double CargoCapacity { get; set; }

    public Truck(Engine engine, Chassis chassis, Transmission transmission, string model, double cargoCapacity)
    {
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
        Model = model;
        CargoCapacity = cargoCapacity;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Truck Information - Model: {Model}, Cargo Capacity: {CargoCapacity} tons");
        Engine.DisplayInfo();
        Chassis.DisplayInfo();
        Transmission.DisplayInfo();
        Console.WriteLine();
    }
}
