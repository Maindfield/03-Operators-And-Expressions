﻿using System;

namespace ExtractBitFromInteger

    //Problem 12. Extract Bit from Integer
    //Write an expression that extracts from given integer n the value of given bit at index p.

{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.Write("Please, enter some number: ");
            int iNumber = int.Parse(Console.ReadLine());

            Console.Write("Please, enter bit position: ");
            int bBitNumber = int.Parse(Console.ReadLine());

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
