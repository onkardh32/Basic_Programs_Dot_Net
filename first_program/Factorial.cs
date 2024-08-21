using System;
using System.Collections.Generic;
using System.Text;

namespace first_program
{
    internal class Factorial
    {
        public static void CalculateFactorial()
        {
            Console.WriteLine("Hey input the number : ");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 0 || userInput == 1)
            {
                Console.WriteLine("Factorial of given number is : " + 1 + " ");
            }
            else
            {
                int ans = 1;
                for(int i = 2; i <= userInput; i++)
                {
                    ans *= i;
                }
                Console.WriteLine("Factorial of given number is : " + ans );
            }


        }
    }
}
