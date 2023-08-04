// Represents a passenger car vehicle with additional properties like model and passenger capacity.
public class PassengerCar
{
    public Engine Engine { get; set; } // Engine of the passenger car.
    public Chassis Chassis { get; set; } // Chassis of the passenger car.
    public Transmission Transmission { get; set; } // Transmission of the passenger car.
    public string Model { get; set; } // Model of the passenger car.
    public int PassengerCapacity { get; set; } // Maximum number of passengers the car can carry.

    // Constructor to initialize the PassengerCar with specified properties.
    public PassengerCar(Engine engine, Chassis chassis, Transmission transmission, string model, int passengerCapacity)
    {
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
        Model = model;
        PassengerCapacity = passengerCapacity;
    }

    // Override the ToString() method to provide a readable representation of the PassengerCar.
    public override string ToString()
    {
        return $"Passenger Car - Model: {Model}, Capacity: {PassengerCapacity} passengers\n{Engine}\n{Chassis}\n{Transmission}";
    }
}
