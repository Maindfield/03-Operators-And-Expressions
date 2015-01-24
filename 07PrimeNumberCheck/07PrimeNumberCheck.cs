using System;

namespace PrimeNumberCheck

    //Problem 8. Prime Number Check
    //Write an expression that checks if given positive integer number n (n <= 100) is prime 
    //(i.e. it is divisible without remainder only to itself and 1).
    //Note: You should check if the number is positive

{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.Write("Enter number <= 100 to check is it prime number: ");
            int number = int.Parse(Console.ReadLine());
      
            while (number < 2 || number > 100)
            {
                Console.WriteLine("Wrong entry, please enter number between 0 and 100");
                Console.Write("Try again: ");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(IsPrime(number));
        }
            static bool IsPrime(int number)
        {
            if (number % 2 == 0)
            {
                if (number == 2)
                {
                    return true;
                }
                    return false;
            }
       
            int max = (int)Math.Sqrt(number);
            for (int i = 3; i <= max; i += 2)
            {
                if ((number % i) == 0)
                {
                   return false;
               }
            }
                   return true;
        }
    }
}
