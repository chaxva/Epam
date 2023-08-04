public static class SymbolSequenceAnalyzer
{
    // Method to find the maximum number of unequal consecutive characters in the given sequence.
    public static int GetMaxConsecutiveUnequal(string sequence)
    {
        // If the sequence is empty or null, there are no consecutive characters.
        if (string.IsNullOrEmpty(sequence))
            return 0;

        int maxConsecutive = 1;
        int currentConsecutive = 1;

        // Loop through the sequence starting from the second character (index 1).
        for (int i = 1; i < sequence.Length; i++)
        {
            // Check if the current character is different from the previous character.
            if (sequence[i] != sequence[i - 1])
            {
                currentConsecutive++;
                // Update the maximum consecutive count by taking the maximum between the current and previous maximum.
                maxConsecutive = Math.Max(maxConsecutive, currentConsecutive);
            }
            else
            {
                // Reset the consecutive count when the current character is equal to the previous one.
                currentConsecutive = 1;
            }
        }

        return maxConsecutive; // Return the maximum number of unequal consecutive characters.
    }
}
