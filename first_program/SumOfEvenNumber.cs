using System;
using System.Collections.Generic;
using System.Text;

namespace first_program
{
    internal class SumOfEvenNumber
    {
        public static void SumEvenDemo()
        {
            Console.Write("Enter the value of N : ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                if(i%2 == 0)
                {
                sum += i;

                }

            }
            Console.WriteLine("The sum of even numbers till "+n+" is "+sum);

        }
    }
}
