// Represents the chassis of a vehicle with various properties.
public class Chassis
{
    public int WheelsNumber { get; set; } // Number of wheels in the chassis.
    public int Number { get; set; } // Chassis number or identification number.
    public double PermissibleLoad { get; set; } // Maximum load capacity in kilograms.

    // Constructor to initialize the chassis with specified properties.
    public Chassis(int wheelsNumber, int number, double permissibleLoad)
    {
        WheelsNumber = wheelsNumber;
        Number = number;
        PermissibleLoad = permissibleLoad;
    }

    // Override the ToString() method to provide a readable representation of the chassis.
    public override string ToString()
    {
        return $"Chassis - Wheels: {WheelsNumber}, Number: {Number}, Permissible Load: {PermissibleLoad} kg";
    }
}
