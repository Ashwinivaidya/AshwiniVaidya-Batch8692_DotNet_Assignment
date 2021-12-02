using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 600, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Console.WriteLine("origanl array element");
            for(int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i] + "");

            }
            Console.WriteLine("\ncheck the number of the array are consective or not"!+test(num));

        }
        public static bool test(int[]num)
        {
            Array.Sort(num);
            for (int i = 1; i < num.Length; i++)
                if (num[i] - num[i - 1] != 1)
                    return false;
            return true;

            {

            }

        }
    }
         
}
