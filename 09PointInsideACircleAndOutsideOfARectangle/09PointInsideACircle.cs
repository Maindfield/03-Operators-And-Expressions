using System;
using System.Globalization;
using System.Threading;

namespace PointInsideACircleAndOutsideOfARectangle

    //Problem 10. Point Inside a Circle & Outside of a Rectangle
    //Write an expression that checks for given point (x, y) if it is within
    //the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

{
    class PointInsideACircleAndOutsideOfARectangle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter X coordinates of a point: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Enter Y coordinates of a point: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Point inside a circle & outside of a rentangle! --> ");
            if ((((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= (1.5 * 1.5))
            {
                if (y > 1)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
