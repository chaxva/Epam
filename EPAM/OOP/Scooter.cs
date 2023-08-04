// Represents a scooter vehicle with additional properties like model and a flag to indicate if it has a basket.
public class Scooter
{
    public Engine Engine { get; set; } // Engine of the scooter.
    public Chassis Chassis { get; set; } // Chassis of the scooter.
    public Transmission Transmission { get; set; } // Transmission of the scooter.
    public string Model { get; set; } // Model of the scooter.
    public bool HasBasket { get; set; } // Flag indicating whether the scooter has a basket or not.

    // Constructor to initialize the Scooter with specified properties.
    public Scooter(Engine engine, Chassis chassis, Transmission transmission, string model, bool hasBasket)
    {
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
        Model = model;
        HasBasket = hasBasket;
    }

    // Override the ToString() method to provide a readable representation of the Scooter.
    public override string ToString()
    {
        return $"Scooter - Model: {Model}, Has Basket: {HasBasket}\n{Engine}\n{Chassis}\n{Transmission}";
    }
}
