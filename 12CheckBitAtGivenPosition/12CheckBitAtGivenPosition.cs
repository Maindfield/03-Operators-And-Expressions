using System;

namespace CheckBitAtGivenPosition

    //Problem 13. Check a Bit at Given Position
    //Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
    //in given integer number n, has value of 1.

{
    class CheckBitAtGivenPosition
    {
        static void Main()
        {
            string number = null;
            string bit = null;

            Console.Write("Enter number: ");
            int intNumber = int.Parse(Console.ReadLine());

            Console.Write("Check witch bit?: ");
            int intBit = int.Parse (Console.ReadLine());

            int mask = 1 << intBit;
            int result = intNumber & mask;
            result >>= intBit;

            bool isItOne = result == 1 ? true : false;
            Console.WriteLine("Is the bit {0} of the number {1}[{2}] is 1? {3}", intBit, intNumber, Convert.ToString(intNumber, 2).PadLeft(32, '0'), isItOne);
        }
            
    }
}
