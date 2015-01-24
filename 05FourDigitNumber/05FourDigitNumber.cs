using System;

namespace FourDigitNumber

        //Problem 6. Four-Digit Number
        //Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        //Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
        //Prints on the console the number in reversed order: dcba (in our example 1102).
        //Puts the last digit in the first position: dabc (in our example 1201).
        //Exchanges the second and the third digits: acbd (in our example 2101).
        //The number has always exactly 4 digits and cannot start with 0.

{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Enter four-digit number: ");
            int inputNumber = int.Parse(Console.ReadLine());
            while (inputNumber > 9999 || inputNumber < 1000)

               {
                    Console.WriteLine("The number must be exactly 4 digits and cannot start with 0. Please, try again!");
                    inputNumber = int.Parse(Console.ReadLine());
               }

            int num1 = inputNumber / 1000;
            int num2 = (inputNumber / 100) % 10;
            int num3 = (inputNumber / 10) % 10;
            int num4 = inputNumber % 10;
            int sum = num1 + num2 + num3 + num4;

            Console.WriteLine("sum of digits: " + sum);
            Console.WriteLine("reversed: {0}{1}{2}{3}", num4, num3, num2, num1);
            Console.WriteLine("last digit in front: {0}{1}{2}{3}", num4, num1, num2, num3);
            Console.WriteLine("second and third digits exchanged: {0}{1}{2}{3}", num1, num3, num2, num4);
        }
    }
}
