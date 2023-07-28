using System;

public static class BaseConverter
{
    public static string ConvertToBase(int decimalNumber, int newBase)
    {
        if (decimalNumber == 0)
        {
            return "0";
        }

        const string digits = "0123456789ABCDEFGHIJ"; // Characters to represent digits beyond 9
        string result = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % newBase;
            result = digits[remainder] + result;
            decimalNumber /= newBase;
        }

        return result;
    }
}
