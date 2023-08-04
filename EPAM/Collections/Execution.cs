using System.Xml.Linq;

namespace Collections
{
    public class Execution
    {
        public static void execution()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            // Create engine, chassis, and transmission objects for each vehicle type
            Engine petrolEngine = new Engine(150, 2.0, "Petrol", "ABC123");
            Chassis sedanChassis = new Chassis(4, 123456, 500);
            Transmission automaticTransmission = new Transmission("Automatic", 6, "XYZ Manufacturer");

            // Add different types of vehicles to the collection
            vehicles.Add(new PassengerCar(petrolEngine, sedanChassis, automaticTransmission, "Sedan X", 5));
            vehicles.Add(new Truck(petrolEngine, new Chassis(6, 789012, 3000), automaticTransmission, "Delivery Truck", 2000));
            vehicles.Add(new Bus(petrolEngine, new Chassis(6, 345678, 5000), new Transmission("Manual", 5, "ABC Manufacturer"), "School Bus", 40));
            vehicles.Add(new Scooter(new Engine(10, 0.5, "Petrol", "XYZ987"), new Chassis(2, 13579, 50), new Transmission("Automatic", 1, "Scooter Manufacturer"), "City Scooter", true));

            // Generate XML files based on the specified criteria
            GenerateEngineCapacityXML(vehicles);
            GenerateBusAndTruckInfoXML(vehicles);
            GenerateTransmissionGroupedXML(vehicles);

            Console.WriteLine();



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

        // Method to generate XML file containing all vehicles with engine capacity > 1.5 liters
        static void GenerateEngineCapacityXML(List<Vehicle> vehicles)
        {
            var filteredVehicles = vehicles.Where(v => v.Engine.Volume > 1.5).ToList();

            XDocument engineCapacityXml = new XDocument(
                new XElement("Vehicles",
                    from vehicle in filteredVehicles
                    select new XElement(vehicle.GetType().Name,
                        new XElement("Model", vehicle.Model),
                        new XElement("Engine",
                            new XElement("Power", vehicle.Engine.Power),
                            new XElement("Volume", vehicle.Engine.Volume),
                            new XElement("Type", vehicle.Engine.Type),
                            new XElement("SerialNumber", vehicle.Engine.SerialNumber)
                        )
                    )
                )
            );

            engineCapacityXml.Save("engine_capacity.xml");
            Console.WriteLine("Engine capacity XML file generated.");
        }

        // Method to generate XML file containing engine type, serial number, and power rating for buses and trucks
        static void GenerateBusAndTruckInfoXML(List<Vehicle> vehicles)
        {
            var busAndTruckInfo = vehicles.Where(v => v is Bus || v is Truck).ToList();

            XDocument busAndTruckXml = new XDocument(
                new XElement("Vehicles",
                    from vehicle in busAndTruckInfo
                    select new XElement(vehicle.GetType().Name,
                        new XElement("Model", vehicle.Model),
                        new XElement("Engine",
                            new XElement("Power", vehicle.Engine.Power),
                            new XElement("Type", vehicle.Engine.Type),
                            new XElement("SerialNumber", vehicle.Engine.SerialNumber)
                        )
                    )
                )
            );

            busAndTruckXml.Save("bus_and_truck_info.xml");
            Console.WriteLine("Bus and truck info XML file generated.");
        }

        // Method to generate XML file containing all vehicles grouped by transmission type
        static void GenerateTransmissionGroupedXML(List<Vehicle> vehicles)
        {
            var groupedByTransmission = vehicles.GroupBy(v => v.Transmission.Type).ToList();

            XDocument transmissionGroupedXml = new XDocument(
                new XElement("Vehicles",
                    from vehicle in groupedByTransmission
                    select new XElement("TransmissionGroup",
                        new XElement("Type", vehicle.Key),
                        vehicle.Select(vehicle => new XElement(vehicle.GetType().Name,
                            new XElement("Model", vehicle.Model),
                            new XElement("Engine",
                                new XElement("Power", vehicle.Engine.Power),
                                new XElement("Volume", vehicle.Engine.Volume),
                                new XElement("Type", vehicle.Engine.Type),
                                new XElement("SerialNumber", vehicle.Engine.SerialNumber)
                            ),
                            new XElement("Chassis",
                                new XElement("WheelsNumber", vehicle.Chassis.WheelsNumber),
                                new XElement("Number", vehicle.Chassis.Number),
                                new XElement("PermissibleLoad", vehicle.Chassis.PermissibleLoad)
                            ),
                            new XElement("Transmission",
                                new XElement("Type", vehicle.Transmission.Type),
                                new XElement("NumberOfGears", vehicle.Transmission.NumberOfGears),
                                new XElement("Manufacturer", vehicle.Transmission.Manufacturer)
                            )
                        ))
                    )
                )
            );

            transmissionGroupedXml.Save("transmission_grouped.xml");
            Console.WriteLine("Transmission grouped XML file generated.");
        }
    }
}
