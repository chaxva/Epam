using System;

public class Chassis
{
    public int WheelsNumber { get; set; }
    public string Number { get; set; }
    public double PermissibleLoad { get; set; }

    public Chassis(int wheelsNumber, string number, double permissibleLoad)
    {
        WheelsNumber = wheelsNumber;
        Number = number;
        PermissibleLoad = permissibleLoad;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Chassis Information: Wheels: {WheelsNumber}, Number: {Number}, Permissible Load: {PermissibleLoad} tons");
    }
}
