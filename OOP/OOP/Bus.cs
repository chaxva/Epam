using System;

public class Bus
{
    public Engine Engine { get; set; }
    public Chassis Chassis { get; set; }
    public Transmission Transmission { get; set; }
    public string Model { get; set; }
    public int PassengerCapacity { get; set; }

    public Bus(Engine engine, Chassis chassis, Transmission transmission, string model, int passengerCapacity)
    {
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
        Model = model;
        PassengerCapacity = passengerCapacity;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Bus Information - Model: {Model}, Passenger Capacity: {PassengerCapacity}");
        Engine.DisplayInfo();
        Chassis.DisplayInfo();
        Transmission.DisplayInfo();
        Console.WriteLine();
    }
}
