using System;
using System.Collections.Generic;
using System.Text;

namespace first_program
{
    internal class PrimeCheck
    {
        public static void CheckPrimeDemo()
        {
            Console.WriteLine("Hey input  number : ");
            int userInput = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for(int i = 2; i < userInput; i++)
            {
                if (userInput % 2 == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("The number you've entered is a prime number " );
            }
            else
            {
                Console.WriteLine("The number you've entered is a not prime number ");
            }
           


        }

    }
}
