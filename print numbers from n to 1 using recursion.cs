using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class print_numbers_from_n_to_1_using_recursion
	{
		static int printNatural(int ctr, int stval)
		{
			if (ctr < 1)
			{
				return stval;
			}

			Console.Write(" {0} ", ctr);
			ctr--;
			return printNatural(ctr, stval);
		}

		static void main()
		{
			Console.Write("\n\n Recursion : Print the natural numbers from n to 1 :\n");
			Console.Write("--------------------------------------------------------\n");
			Console.Write(" How many numbers to print : ");
			int ctr = Convert.ToInt32(Console.ReadLine());
			// Call recursive method with two parameters.	
			printNatural(ctr, 1);
			Console.Write("\n\n");
		}
	}
}

