namespace OOP
{
    public class Execution
    {
        // Main method to create instances of different vehicles and print their information.
        public static void execution()
        {
            // Create engine, chassis, and transmission objects for each vehicle type
            Engine petrolEngine = new Engine(150, 2.0, "Petrol", "ABC123");
            Chassis sedanChassis = new Chassis(4, 123456, 500);
            Transmission automaticTransmission = new Transmission("Automatic", 6, "XYZ Manufacturer");

            // Create different types of vehicles
            PassengerCar sedanCar = new PassengerCar(petrolEngine, sedanChassis, automaticTransmission, "Sedan X", 5);
            Truck deliveryTruck = new Truck(petrolEngine, new Chassis(6, 789012, 3000), automaticTransmission, "Delivery Truck", 2000);
            Bus schoolBus = new Bus(petrolEngine, new Chassis(6, 345678, 5000), new Transmission("Manual", 5, "ABC Manufacturer"), "School Bus", 40);
            Scooter cityScooter = new Scooter(new Engine(10, 0.5, "Petrol", "XYZ987"), new Chassis(2, 13579, 50), new Transmission("Automatic", 1, "Scooter Manufacturer"), "City Scooter", true);

            // Print the information about each vehicle
            Console.WriteLine(sedanCar);
            Console.WriteLine("\n");
            Console.WriteLine(deliveryTruck);
            Console.WriteLine("\n");
            Console.WriteLine(schoolBus);
            Console.WriteLine("\n");
            Console.WriteLine(cityScooter);
        }
    }
}
