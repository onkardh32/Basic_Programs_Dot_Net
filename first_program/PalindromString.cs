using System;
using System.Collections.Generic;
using System.Text;

namespace first_program
{
    internal class PalindromString
    {
        public static void PalindromeStringCheck()
        {
            Console.WriteLine("Enter the string : ");
            string inputString= Console.ReadLine();

            int i=0, j = inputString.Length-1;
            while (i < j)
            {
               if(inputString[i] != inputString[j])
                {
                    Console.WriteLine("The String " + inputString + " is not a palindrome ");
                    return;
                }
                i++; 
                j--;

            }
            Console.WriteLine("The String " + inputString + " is a palindrome ");
        }
    }
}
