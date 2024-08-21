using System;
using System.Collections.Generic;
using System.Text;

namespace first_program
{
    internal class ReverseString
    {
        public static void Reverse()
        {
            Console.WriteLine("Enter the string : ");
            string inputString = Console.ReadLine();

            // int i = 0, j = inputString.Length - 1;
            //while (i < j)
            //{
            //    char temp=inputString[i];
            //    inputString[i] = inputString[j];

            //    i++;
            //    j--;

            //}

            string reversed = "";

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reversed += inputString[i];
            }
            Console.WriteLine("Reversed String for " + inputString + " is " + reversed);
        }
    }
}
