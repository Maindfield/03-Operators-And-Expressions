using System;

namespace ThirdDigitIs7

    //Problem 5. Third Digit is 7?
    //Write an expression that checks for given integer if its third digit from right-to-left is 7.

{
    class ThirdDigitIs7
    {
        static void Main()
        {

            Console.Write("Enter number to check: ");
            int input = int.Parse(Console.ReadLine());

            bool check = (input % 1000 > 699 && input % 1000 < 800);
            Console.WriteLine("Is the third digit from right to left 7? = {0}", check);

        }
    }
}