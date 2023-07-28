using System;

class Program
{
    static void Main()
    {
        // Create engine, chassis, and transmission instances as required
        Engine engine1 = new Engine(150, 2.0, "Gasoline", "ENG123");
        Chassis chassis1 = new Chassis(4, "CHS456", 2.5);
        Transmission transmission1 = new Transmission("Automatic", 6, "ABC Transmissions");
        PassengerCar car1 = new PassengerCar(engine1, chassis1, transmission1, "Sedan", 5);
        car1.DisplayInfo();

        Engine engine2 = new Engine(300, 3.5, "Diesel", "ENG789");
        Chassis chassis2 = new Chassis(6, "CHS012", 10.0);
        Transmission transmission2 = new Transmission("Manual", 8, "XYZ Transmissions");
        Truck truck1 = new Truck(engine2, chassis2, transmission2, "Truck 1", 20);
        truck1.DisplayInfo();

        // Create and display information for other vehicle types (e.g., Bus, Scooter) as needed
        // ...

        Console.ReadLine();
    }
}
