using System;

namespace PointInACircle

                //Problem 7. Point in a Circle
                //Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

{
    class PointInACircle
    {
        static void Main()
        {
            Console.Write("Enter coordinate x of the point: ");
            float x = float.Parse(Console.ReadLine());

            Console.Write("Enter coordinate y of the point: ");
            float y = float.Parse(Console.ReadLine());

            byte rad = 2;
            bool inCircle = x * x + y * y <= rad * rad;
            Console.WriteLine("{0}", inCircle);
        }
    }
}
