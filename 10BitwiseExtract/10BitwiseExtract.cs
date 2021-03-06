﻿using System;

namespace BitwiseExtract

    //Problem 11. Bitwise: Extract Bit #3
    //Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
    //The bits are counted from right to left, starting from bit #0.
    //The result of the expression should be either 1 or 0.

{
    class BitwiseExtract
    {
        static void Main()
        {
            Console.Write("Please, enter number: ");
            int iNumber = int.Parse(Console.ReadLine());
            int bBitNumber = 3;
            byte value = 1;
            int newNumber = (iNumber >> bBitNumber) & 1;
            if (newNumber == 0)
            {
                value = 0;
            }
            else
            {
                value = 1;
            }
            Console.WriteLine(Convert.ToString(iNumber, 2).PadLeft(16, '0'));
            Console.WriteLine("The value of the bit #{0} is {1}", bBitNumber, value);
        }
    }
}
