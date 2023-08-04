// Chassis class represents the chassis of a vehicle
public class Chassis
{
    // Properties of a chassis
    public int WheelsNumber { get; set; }
    public int Number { get; set; }
    public double PermissibleLoad { get; set; }

    // Constructor to initialize the Chassis object
    public Chassis(int wheelsNumber, int number, double permissibleLoad)
    {
        WheelsNumber = wheelsNumber;
        Number = number;
        PermissibleLoad = permissibleLoad;
    }

    // Override the ToString() method to provide a custom string representation of the Chassis object
    public override string ToString()
    {
        return $"Chassis - Wheels: {WheelsNumber}, Number: {Number}, Permissible Load: {PermissibleLoad} kg";
    }
}
