namespace NumberConverterApp
{
    static class NumberConverter
    {
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

            while (number > 0)
            {
                int remainder = number % newBase;
                result = characters[remainder] + result;
                number /= newBase;
            }

            if (isNegative)
                result = "-" + result;

            return result;
        }
    }
}
