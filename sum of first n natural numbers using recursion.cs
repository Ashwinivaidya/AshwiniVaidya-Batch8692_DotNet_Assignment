using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class sum_of_first_n_natural_numbers_using_recursion
    {
        static void main(string[] args)
        {
            Console.Write("\n\n Recursion : Sum of first n natural numbers :\n");
            Console.Write("--------------------------------------------------\n");
            Console.Write(" How many numbers to sum : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(" The sum of first {0} natural numbers is : {1}\n\n", n, SumOfTen(1, n));
        }

        static int SumOfTen(int min, int max)
        {
            return CalcuSum(min, max);
        }

        static int CalcuSum(int min, int val)
        {
            if (val == min)
                return val;
            return val + CalcuSum(min, val - 1);
        }
    }

}

