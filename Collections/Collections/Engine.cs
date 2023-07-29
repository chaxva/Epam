﻿public class Engine
{
    public int Power { get; set; }
    public double Volume { get; set; }
    public string Type { get; set; }
    public string SerialNumber { get; set; }

    public Engine(int power, double volume, string type, string serialNumber)
    {
        Power = power;
        Volume = volume;
        Type = type;
        SerialNumber = serialNumber;
    }

    public override string ToString()
    {
        return $"Engine - Power: {Power} HP, Volume: {Volume}L, Type: {Type}, Serial Number: {SerialNumber}";
    }
}