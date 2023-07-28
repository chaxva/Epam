using System;

public class Transmission
{
    public string Type { get; set; }
    public int NumberOfGears { get; set; }
    public string Manufacturer { get; set; }

    public Transmission(string type, int numberOfGears, string manufacturer)
    {
        Type = type;
        NumberOfGears = numberOfGears;
        Manufacturer = manufacturer;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Transmission Information: Type: {Type}, Number of Gears: {NumberOfGears}, Manufacturer: {Manufacturer}");
    }
}
