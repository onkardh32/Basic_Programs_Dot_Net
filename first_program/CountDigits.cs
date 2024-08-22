using System;
using System.Collections.Generic;
using System.Text;

namespace first_program
{
    class CountDigits
    {
        public static void DigitCountDemo()
        {
            Console.Write("Enter the Number : ");
            int number = int.Parse(Console.ReadLine());
            int count = 0; int temp = number;

            while (temp > 0)
            {

                count += 1;
                temp = temp / 10;
            }

            Console.WriteLine("The total digits  : "+number +" has is " + count);
        }
    }
}
