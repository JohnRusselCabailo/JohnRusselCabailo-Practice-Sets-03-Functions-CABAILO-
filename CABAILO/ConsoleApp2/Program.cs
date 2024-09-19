using System;
using System.Formats.Asn1;

namespace Cabailo
{

    public class HelloWorld
    {

        static bool LeapYear(int year)
        {
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0) )
            { 
                return true;
            }
                return false;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Year:");
            int year = Convert.ToInt32(Console.ReadLine());

            bool result = LeapYear(year);

            if (result == true)
            {
                Console.WriteLine($"The Year {year} is a leap year");
            }
            else
            {
                Console.WriteLine($"The Year {year} is not a leap year");
            }
        }

    }
}
