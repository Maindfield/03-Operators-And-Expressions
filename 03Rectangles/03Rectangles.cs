using System;
using System.Globalization;
using System.Threading;

namespace Rectangles

    //Problem 4. Rectangles
    //Write an expression that calculates rectangle’s perimeter and area by given width and height.

{
    class Rectangles
    {
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write ("Enter width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter height of the rectangle: ");
            double height = double.Parse(Console.ReadLine());

            double perimeter = width * height;
            double area = (width + height) * 2;

            Console.WriteLine("The perimater of rectangle is: {0}\nThe area of this rectangle is: {1}", area, perimeter); 

        }
    }
}
