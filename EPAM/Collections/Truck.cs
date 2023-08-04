// Truck class represents a type of vehicle that inherits from the Vehicle class
public class Truck : Vehicle
{
    // Additional property specific to trucks
    public double CargoCapacity { get; set; }

    // Constructor to initialize the Truck object
    public Truck(Engine engine, Chassis chassis, Transmission transmission, string model, double cargoCapacity)
        : base(engine, chassis, transmission, model)
    {
        CargoCapacity = cargoCapacity;
    }

    // Override the ToString() method to provide a custom string representation of the Truck object
    public override string ToString()
    {
        return $"Truck - Model: {Model}, Cargo Capacity: {CargoCapacity} kg\n{Engine}\n{Chassis}\n{Transmission}";
    }

    // Override the abstract method from the base class to compare engine capacity with the given value
    public override bool IsEngineCapacityGreaterThan(double capacity)
    {
        return Engine.Volume > capacity;
    }
}
