using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        if (CommandLineArgsParser.TryParseCommandLineArgs(args, out int decimalNumber, out int newBase))
        {
            string convertedNumber = BaseConverter.ConvertToBase(decimalNumber, newBase);
            Console.WriteLine($"Decimal {decimalNumber} converted to base {newBase}: {convertedNumber}");
        }
    }
}
