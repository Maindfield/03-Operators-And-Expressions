using System;

namespace DivideBy7and5

    //Problem 3. Divide by 7 and 5
    //Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

{
    class DivideBy7and5
    {
        static void Main()
        {
            Console.Write ("Enter number to see is it divisible to 7 and 5 at the same time: ");
            int input = int.Parse(Console.ReadLine());
            bool check = ((input % 5 ) == 0) && ((input % 7 == 0 ));

            Console.WriteLine("The answer is: {0}", check);
        }
    }
}
