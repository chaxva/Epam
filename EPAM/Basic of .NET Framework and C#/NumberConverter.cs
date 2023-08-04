namespace NumberConverterApp
{
    static class NumberConverter
    {
        // Converts a given decimal number to a specified base.
        public static string ConvertToBase(int number, int newBase)
        {
            const string characters = "0123456789ABCDEFGHIJ";
            if (newBase < 2 || newBase > characters.Length)
                throw new System.ArgumentException("The base must be between 2 and 20.", nameof(newBase));

            if (number == 0)
                return "0";

            bool isNegative = number < 0;
            number = System.Math.Abs(number);
            string result = "";

            // Convert the number to the new base.
            while (number > 0)
            {
                int remainder = number % newBase;
                result = characters[remainder] + result;
                number /= newBase;
            }

            if (isNegative)
                result = "-" + result;

            return result; // Returns the converted number in the specified base.
        }
    }
}
