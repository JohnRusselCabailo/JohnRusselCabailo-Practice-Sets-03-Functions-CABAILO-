using System;
using System.Formats.Asn1;

namespace Cabailo
{

    public class HelloWorld
    {

        static double HeronsFormula(double ft, double st, double tt)
        {
            double s = (ft + st + tt) / 2;
            double area = Math.Sqrt(s*(s-ft)*(s-st)*(s-tt));
            return area;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first side of triangle:");
            double ft = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second side of triangle:");
            double st = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the third side of triangle:");
            double tt = Convert.ToDouble(Console.ReadLine());

            double result = HeronsFormula(ft, st, tt);

            Console.WriteLine($"The result of area in triangle is {result}");
        }

    }
}