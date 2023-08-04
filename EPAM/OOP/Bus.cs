// Represents a bus vehicle with additional properties like model and passenger capacity.
public class Bus
{
    public Engine Engine { get; set; } // Engine of the bus.
    public Chassis Chassis { get; set; } // Chassis of the bus.
    public Transmission Transmission { get; set; } // Transmission of the bus.
    public string Model { get; set; } // Model of the bus.
    public int PassengerCapacity { get; set; } // Maximum number of passengers the bus can carry.

    // Constructor to initialize the Bus with specified properties.
    public Bus(Engine engine, Chassis chassis, Transmission transmission, string model, int passengerCapacity)
    {
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
        Model = model;
        PassengerCapacity = passengerCapacity;
    }

    // Override the ToString() method to provide a readable representation of the Bus.
    public override string ToString()
    {
        return $"Bus - Model: {Model}, Passenger Capacity: {PassengerCapacity} passengers\n{Engine}\n{Chassis}\n{Transmission}";
    }
}
