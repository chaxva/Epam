public class Bus
{
    public Engine Engine { get; set; }
    public Chassis Chassis { get; set; }
    public Transmission Transmission { get; set; }
    public string Model { get; set; }
    public int PassengerCapacity { get; set; }

    public Bus(Engine engine, Chassis chassis, Transmission transmission, string model, int passengerCapacity)
    {
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
        Model = model;
        PassengerCapacity = passengerCapacity;
    }

    public override string ToString()
    {
        return $"Bus - Model: {Model}, Passenger Capacity: {PassengerCapacity} passengers\n{Engine}\n{Chassis}\n{Transmission}";
    }
}
