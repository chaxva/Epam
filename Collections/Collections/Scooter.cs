// Scooter.cs

public class Scooter
{
    public Engine Engine { get; set; }
    public Chassis Chassis { get; set; }
    public Transmission Transmission { get; set; }
    public string Model { get; set; }
    public bool HasBasket { get; set; }

    public Scooter(Engine engine, Chassis chassis, Transmission transmission, string model, bool hasBasket)
    {
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
        Model = model;
        HasBasket = hasBasket;
    }

    public override string ToString()
    {
        return $"Scooter - Model: {Model}, Has Basket: {HasBasket}\n{Engine}\n{Chassis}\n{Transmission}";
    }
}
