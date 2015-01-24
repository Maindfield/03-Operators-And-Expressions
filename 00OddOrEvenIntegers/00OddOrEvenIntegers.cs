using System;

namespace OddOrEvenIntegers

{
      //Problem 1. Odd or Even Integers
      //Write an expression that checks if given integer is odd or even.

    class OddOrEvenIntegers
    {
        static void Main()
        {

            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            bool checkOdd = number % 2 != 0;

            Console.WriteLine("Is the Number ODD {0} ----> {1}", number, checkOdd);
      
        }
      
    }
}