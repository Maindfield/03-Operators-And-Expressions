using System;
using System.Globalization;
using System.Threading;

namespace Trapezoids

    //Problem 9. Trapezoids
    //Write an expression that calculates trapezoid's area by given sides a and b and height h.

{
    class Trapezoids
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Type base 'a': ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Type base 'b': ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Type height: ");
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;
            Console.WriteLine("Area: {0}", area);
        }
    }
}
