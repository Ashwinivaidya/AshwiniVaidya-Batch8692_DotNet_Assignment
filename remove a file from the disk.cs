using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class remove_a_file_from_the_disk
    {
        public static void Main()
        {
            string fileName = @"mytest.txt";
            Console.Write("\n\n Remove a file from the disk (at first create the file ) :\n");
            Console.Write("--------------------------------------------------------------\n");

            // Delete the file if it exists.
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine(" The file {0} deleted successfully.\n\n", fileName);
            }
            else
            {
                Console.WriteLine(" File does not exist");
                Console.ReadKey();
            }
        }
    }
}

