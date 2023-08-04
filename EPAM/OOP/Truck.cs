// Represents a truck vehicle with additional properties like model and cargo capacity.
public class Truck
{
    public Engine Engine { get; set; } // Engine of the truck.
    public Chassis Chassis { get; set; } // Chassis of the truck.
    public Transmission Transmission { get; set; } // Transmission of the truck.
    public string Model { get; set; } // Model of the truck.
    public double CargoCapacity { get; set; } // Maximum cargo capacity of the truck in kilograms.

    // Constructor to initialize the Truck with specified properties.
    public Truck(Engine engine, Chassis chassis, Transmission transmission, string model, double cargoCapacity)
    {
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
        Model = model;
        CargoCapacity = cargoCapacity;
    }

    // Override the ToString() method to provide a readable representation of the Truck.
    public override string ToString()
    {
        return $"Truck - Model: {Model}, Cargo Capacity: {CargoCapacity} kg\n{Engine}\n{Chassis}\n{Transmission}";
    }
}
