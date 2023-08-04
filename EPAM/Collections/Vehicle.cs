// Vehicle class is an abstract class representing a generic vehicle
public abstract class Vehicle
{
    // Properties of a vehicle
    public Engine Engine { get; set; }
    public Chassis Chassis { get; set; }
    public Transmission Transmission { get; set; }
    public string Model { get; set; }

    // Constructor to initialize the Vehicle object
    public Vehicle(Engine engine, Chassis chassis, Transmission transmission, string model)
    {
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
        Model = model;
    }

    // Abstract method to be implemented in derived classes to compare engine capacity with the given value
    public abstract bool IsEngineCapacityGreaterThan(double capacity);
}
