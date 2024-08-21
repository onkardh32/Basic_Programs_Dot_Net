using System;
using System.Collections.Generic;
using System.Text;

namespace first_program
{
    internal class DigitSum
    {
        public static void SumDigitDemo()
        {
            Console.Write("Enter the Number : ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number > 0)
            {
                
                sum = sum + (number%10);
                number = number / 10;
            }

            Console.WriteLine("The Sum of Digits is : "+sum);
           
        }
    }
}
