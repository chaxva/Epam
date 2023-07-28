using System;

class Program
{
    static void Main()
    {
        string[] args = CommandLineArgsParser.GetCommandLineArgs();

        if (args.Length == 0)
        {
            Console.WriteLine("Please provide a sequence of symbols as command-line arguments.");
            return;
        }

        foreach (string arg in args)
        {
            int maxConsecutiveUnequal = SymbolSequenceAnalyzer.GetMaxConsecutiveUnequal(arg);
            Console.WriteLine($"For the sequence: \"{arg}\", the maximum number of unequal consecutive characters is: {maxConsecutiveUnequal}");
        }
    }
}
