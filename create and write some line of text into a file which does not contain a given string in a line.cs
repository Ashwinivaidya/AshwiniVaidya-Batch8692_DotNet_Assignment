using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class create_and_write_some_line_of_text_into_a_file_which_does_not_contain_a_given_string_in_a_line
    {
        static void Main()
        {
            string fileName = @"mytest.txt";
            string[] ArrLines;
            string str;

            int n, i;

            Console.Write("\n\n Create and write some line of text which does not contain a given string in a line  :\n");
            Console.Write("------------------------------------------------------------------------------------------\n");

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            Console.Write(" Input the string to ignore the line : ");
            str = Console.ReadLine();
            Console.Write(" Input number of lines to write in the file  : ");
            n = Convert.ToInt32(Console.ReadLine());
            ArrLines = new string[n];

            Console.Write(" Input {0} strings below :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write(" Input line {0} : ", i + 1);
                ArrLines[i] = Console.ReadLine();
            }

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"mytest.txt"))
            {
                foreach (string line in ArrLines)
                {
                    if (!line.Contains(str)) // write the line to the file If it doesn't contain the string in str
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                Console.Write("\n The line has ignored which contain the string '{0}'. \n", str);
                Console.Write("\n The content of the file is  :\n", n);
                Console.Write("----------------------------------\n");
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(" {0} ", s);
                }
                Console.WriteLine();
            }
        }
    }
}

