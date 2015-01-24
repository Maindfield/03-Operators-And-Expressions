﻿using System;

namespace ModifyBitAtGivenPosition

            //Problem 14. Modify a Bit at Given Position
            //We are given an integer number n, a bit value v (v=0 or 1) and a position p.
            //Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from
            //the binary representation of n while preserving all other bits in n.
{
    class ModifyBitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("Please, enter some number: ");
            int nNumber = int.Parse(Console.ReadLine());

            Console.Write("Please, enter bit position p to modify: ");
            byte position = byte.Parse(Console.ReadLine());

            Console.Write("Please, enter bit value 0 or 1: ");
            byte bitValue = byte.Parse(Console.ReadLine());

            Console.WriteLine("INPUT: " + Convert.ToString(nNumber, 2).PadLeft(16, '0'));
            if (bitValue == 0)
            {
              
                int mask = ~(1 << position);
                int result = nNumber & mask;
                Console.WriteLine("RESULT:" + Convert.ToString(result, 2).PadLeft(16, '0'));
                Console.WriteLine(result);
            }
            else if (bitValue == 1)
            {
             
                int mask = 1 << position;
                int result = nNumber | mask;
                Console.WriteLine("RESULT:" + Convert.ToString(result, 2).PadLeft(16, '0'));
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Wrong input! Try Again.");
            }
        }
    }
}