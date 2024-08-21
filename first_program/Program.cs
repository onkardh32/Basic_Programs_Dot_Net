using System;

namespace first_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate();
        }

        public static void Calculate()
        {
            int num = 10;
            if (num % 2 == 0)
            {
                Console.WriteLine("The given number " + num + " is an even number");
            }
            else
            {
                Console.WriteLine("The given number " + num + " is Odd number");
            }

        }
                    
    }
}
