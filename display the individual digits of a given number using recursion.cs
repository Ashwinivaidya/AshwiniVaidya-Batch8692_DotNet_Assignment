using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class display_the_individual_digits_of_a_given_number_using_recursion
    {
        static void Main()
        {

            Console.Write("\n\n Recursion : Display the individual digits of a given number :\n");
            Console.Write("------------------------------------------------------------------\n");
            Console.Write(" Input any number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write(" The digits in the number {0} are : ", num);
            separateDigits(num);
            Console.Write("\n\n");
        }

        static void separateDigits(int n)
        {
            if (n < 10)
            {
                Console.Write("{0}  ", n);
                return;
            }
            separateDigits(n / 10);
            Console.Write(" {0} ", n % 10);
        }
    }
}

