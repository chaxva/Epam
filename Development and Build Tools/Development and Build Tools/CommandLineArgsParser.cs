using System;

public static class CommandLineArgsParser
{
    public static string[] GetCommandLineArgs()
    {
        string[] args = Environment.GetCommandLineArgs();
        return args.Length > 1 ? args[1..] : Array.Empty<string>();
    }
}
