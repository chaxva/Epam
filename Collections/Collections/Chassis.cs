public class Chassis
{
    public int WheelsNumber { get; set; }
    public int Number { get; set; }
    public double PermissibleLoad { get; set; }

    public Chassis(int wheelsNumber, int number, double permissibleLoad)
    {
        WheelsNumber = wheelsNumber;
        Number = number;
        PermissibleLoad = permissibleLoad;
    }

    public override string ToString()
    {
        return $"Chassis - Wheels: {WheelsNumber}, Number: {Number}, Permissible Load: {PermissibleLoad} kg";
    }
}
