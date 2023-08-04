public class Method
{
    // Method to calculate the maximum number of unequal consecutive characters in the given sequence.
    static int GetMaxUnequalConsecutiveCharacters(string sequence)
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
                // If the characters are unequal, increase the count of consecutive unequal characters.
                currentConsecutive++;
            }
            else
            {
                // If the characters are equal, reset the count of consecutive unequal characters.
                currentConsecutive = 1;
            }

            // Update the maximum consecutive count by taking the maximum between the current and previous maximum.
            maxConsecutive = Math.Max(maxConsecutive, currentConsecutive);
        }

        return maxConsecutive; // Return the maximum number of unequal consecutive characters.
    }

    public static void execution()
    {
        Console.WriteLine("Enter a sequence of symbols:");
        string sequence = Console.ReadLine();

        // Call the method to get the maximum number of unequal consecutive characters.
        int maxConsecutive = GetMaxUnequalConsecutiveCharacters(sequence);

        // Print the result to the console.
        Console.WriteLine($"Maximum number of unequal consecutive characters: {maxConsecutive}");
    }
}
