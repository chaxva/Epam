public static class CommandLineArgsParser
{
    // Parses the command-line arguments to extract the decimal number and the new base.
    public static bool TryParseCommandLineArgs(string[] args, out int decimalNumber, out int newBase)
    {
        decimalNumber = 0;
        newBase = 0;

        if (args.Length != 2)
        {
            Console.WriteLine("Usage: Program <decimalNumber> <newBase>");
            return false;
        }

        if (!int.TryParse(args[0], out decimalNumber))
        {
            Console.WriteLine("Invalid decimal number. Please enter a valid integer.");
            return false;
        }

        if (!int.TryParse(args[1], out newBase) || newBase < 2 || newBase > 20)
        {
            Console.WriteLine("Invalid new base. Please enter a valid integer between 2 and 20.");
            return false;
        }

        return true; // Returns true if command-line arguments were successfully parsed.
    }
}
