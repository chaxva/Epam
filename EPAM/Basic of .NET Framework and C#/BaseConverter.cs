public static class BaseConverter
{
    // Converts a given decimal number to a specified base (up to base 20).
    public static string ConvertToBase(int decimalNumber, int newBase)
    {
        if (decimalNumber == 0)
        {
            return "0"; // If the decimal number is 0, the result will be "0" in any base.
        }

        const string digits = "0123456789ABCDEFGHIJ"; // Characters to represent digits beyond 9.
        string result = "";

        // Convert the number to the new base.
        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % newBase;
            result = digits[remainder] + result;
            decimalNumber /= newBase;
        }

        return result; // Returns the converted number in the specified base.
    }
}
