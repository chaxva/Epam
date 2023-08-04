public static class CommandLineArgsParser
{
    // Method to get command-line arguments, excluding the first argument (program name).
    public static string[] GetCommandLineArgs()
    {
        string[] args = Environment.GetCommandLineArgs();
        return args.Length > 1 ? args[1..] : Array.Empty<string>();
    }
}
