// Bus class represents a type of vehicle that inherits from the Vehicle class
public class Bus : Vehicle
{
    // Additional property specific to buses
    public int PassengerCapacity { get; set; }

    // Constructor to initialize the Bus object
    public Bus(Engine engine, Chassis chassis, Transmission transmission, string model, int passengerCapacity)
        : base(engine, chassis, transmission, model)
    {
        PassengerCapacity = passengerCapacity;
    }

    // Override the ToString() method to provide a custom string representation of the Bus object
    public override string ToString()
    {
        return $"Bus - Model: {Model}, Passenger Capacity: {PassengerCapacity} passengers\n{Engine}\n{Chassis}\n{Transmission}";
    }

    // Override the abstract method from the base class to compare engine capacity with the given value
    public override bool IsEngineCapacityGreaterThan(double capacity)
    {
        return Engine.Volume > capacity;
    }
}
