// Transmission class represents the transmission of a vehicle
public class Transmission
{
    // Properties of a transmission
    public string Type { get; set; }
    public int NumberOfGears { get; set; }
    public string Manufacturer { get; set; }

    // Constructor to initialize the Transmission object
    public Transmission(string type, int numberOfGears, string manufacturer)
    {
        Type = type;
        NumberOfGears = numberOfGears;
        Manufacturer = manufacturer;
    }

    // Override the ToString() method to provide a custom string representation of the Transmission object
    public override string ToString()
    {
        return $"Transmission - Type: {Type}, Number of Gears: {NumberOfGears}, Manufacturer: {Manufacturer}";
    }
}
