using NumberConverterApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_of_.NET_Framework_and_C_
{
    internal class Execution
    {
        public static void execution(String[]args)
        {
            Console.WriteLine("Enter a number in decimal: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid number input. Please enter a valid integer.");
                return;
            }

            Console.WriteLine("Enter the new base (between 2 and 20): ");
            if (!int.TryParse(Console.ReadLine(), out int newBase) || newBase < 2 || newBase > 20)
            {
                Console.WriteLine("Invalid base input. Please enter a valid integer between 2 and 20.");
                return;
            }

            string convertedNumber = NumberConverter.ConvertToBase(number, newBase);
            Console.WriteLine($"The number {number} in base {newBase} is: {convertedNumber}");
        }
    }
}
