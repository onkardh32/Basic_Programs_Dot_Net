using System;
using System.Collections.Generic;
using System.Text;

namespace first_program
{
    internal class SwapNumber
    {
        public static void SwapDemo()
        {
            Console.WriteLine("Hey input 1st number : ");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Hey input 2nd number : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nBefore Swapping : ");
            Console.WriteLine("Number 1 : " + num1 + "\nNumber 2: " + num2);

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\n\nAfter Swapping : ");
            Console.WriteLine("Number 1 : " + num1 + "\nNumber 2: " + num2);


        }

    }
}
