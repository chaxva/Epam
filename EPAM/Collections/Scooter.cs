// Scooter class represents a type of vehicle that inherits from the Vehicle class
public class Scooter : Vehicle
{
    // Additional property specific to scooters
    public bool HasBasket { get; set; }

    // Constructor to initialize the Scooter object
    public Scooter(Engine engine, Chassis chassis, Transmission transmission, string model, bool hasBasket)
        : base(engine, chassis, transmission, model)
    {
        HasBasket = hasBasket;
    }

    // Override the ToString() method to provide a custom string representation of the Scooter object
    public override string ToString()
    {
        return $"Scooter - Model: {Model}, Has Basket: {HasBasket}\n{Engine}\n{Chassis}\n{Transmission}";
    }

    // Override the abstract method from the base class to compare engine capacity with the given value
    public override bool IsEngineCapacityGreaterThan(double capacity)
    {
        return Engine.Volume > capacity;
    }
}
