// Engine class represents the engine of a vehicle
public class Engine
{
    // Properties of an engine
    public int Power { get; set; }
    public double Volume { get; set; }
    public string Type { get; set; }
    public string SerialNumber { get; set; }

    // Constructor to initialize the Engine object
    public Engine(int power, double volume, string type, string serialNumber)
    {
        Power = power;
        Volume = volume;
        Type = type;
        SerialNumber = serialNumber;
    }

    // Override the ToString() method to provide a custom string representation of the Engine object
    public override string ToString()
    {
        return $"Engine - Power: {Power} HP, Volume: {Volume}L, Type: {Type}, Serial Number: {SerialNumber}";
    }
}
