using System;

namespace GravitationOnTheMoon

    //Problem 2. Gravitation on the MoonS
    //The gravitational field of the Moon is approximately 17% of that on the Earth.
    //Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

{ 
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.Write ("Enter your weight on Earth: ");
            double weightOnEarth = double.Parse(Console.ReadLine());

            Console.WriteLine ("Your Weight on the Moon will be: {0}", weightOnEarth * 0.17 );
        }
    }
}
