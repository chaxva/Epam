// PassengerCar class represents a type of vehicle that inherits from the Vehicle class
public class PassengerCar : Vehicle
{
    // Additional property specific to passenger cars
    public int PassengerCapacity { get; set; }

    // Constructor to initialize the PassengerCar object
    public PassengerCar(Engine engine, Chassis chassis, Transmission transmission, string model, int passengerCapacity)
        : base(engine, chassis, transmission, model)
    {
        PassengerCapacity = passengerCapacity;
    }

    // Override the ToString() method to provide a custom string representation of the PassengerCar object
    public override string ToString()
    {
        return $"Passenger Car - Model: {Model}, Passenger Capacity: {PassengerCapacity} passengers\n{Engine}\n{Chassis}\n{Transmission}";
    }

    // Override the abstract method from the base class to compare engine capacity with the given value
    public override bool IsEngineCapacityGreaterThan(double capacity)
    {
        return Engine.Volume > capacity;
    }
}
