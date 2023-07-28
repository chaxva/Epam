using System;

public static class SymbolSequenceAnalyzer
{
    public static int GetMaxConsecutiveUnequal(string sequence)
    {
        if (string.IsNullOrEmpty(sequence))
            return 0;

        int maxConsecutive = 1;
        int currentConsecutive = 1;

        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] != sequence[i - 1])
            {
                currentConsecutive++;
                maxConsecutive = Math.Max(maxConsecutive, currentConsecutive);
            }
            else
            {
                currentConsecutive = 1;
            }
        }

        return maxConsecutive;
    }
}
