using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main()
        {
            string fileName = @"mytest.txt";
            try
            {
                Console.Write("\n\n Create a file named mytest.txt in the disk :\n");
                Console.Write("------------------------------------------------\n");
                
                using (FileStream fileStr = File.Create(fileName))
                {
                    Console.WriteLine(" A file created with name mytest.txt\n\n");
                }
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
    }

}
        
    