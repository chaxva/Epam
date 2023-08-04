// Represents the transmission system of a vehicle with various properties.
public class Transmission
{
    public string Type { get; set; } // Type of the transmission (e.g., Automatic, Manual).
    public int NumberOfGears { get; set; } // Number of gears in the transmission.
    public string Manufacturer { get; set; } // Manufacturer of the transmission.

    // Constructor to initialize the transmission with specified properties.
    public Transmission(string type, int numberOfGears, string manufacturer)
    {
        Type = type;
        NumberOfGears = numberOfGears;
        Manufacturer = manufacturer;
    }

    // Override the ToString() method to provide a readable representation of the transmission.
    public override string ToString()
    {
        return $"Transmission - Type: {Type}, Number of Gears: {NumberOfGears}, Manufacturer: {Manufacturer}";
    }
}
