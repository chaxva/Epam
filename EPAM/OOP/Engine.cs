// Represents the engine of a vehicle with various properties.
public class Engine
{
    public int Power { get; set; } // Power of the engine in horsepower (HP).
    public double Volume { get; set; } // Engine displacement volume in liters.
    public string Type { get; set; } // Type of the engine (e.g., Petrol, Diesel).
    public string SerialNumber { get; set; } // Serial number of the engine.

    // Constructor to initialize the engine with specified properties.
    public Engine(int power, double volume, string type, string serialNumber)
    {
        Power = power;
        Volume = volume;
        Type = type;
        SerialNumber = serialNumber;
    }

    // Override the ToString() method to provide a readable representation of the engine.
    public override string ToString()
    {
        return $"Engine - Power: {Power} HP, Volume: {Volume}L, Type: {Type}, Serial Number: {SerialNumber}";
    }
}
