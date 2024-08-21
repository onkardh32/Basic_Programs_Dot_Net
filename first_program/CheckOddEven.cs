using System;
using System.Collections.Generic;
using System.Text;

namespace first_program
{
    internal class CheckOddEven
    {
        public static void EvenOddDemo()
        {
            Console.WriteLine("Hey input the number : ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The given input number " + num + " is even !");
            }
            else
            {
                Console.WriteLine("The number " + num + " is odd ! ");
            }
        }
    }
}
