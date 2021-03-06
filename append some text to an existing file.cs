using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class append_some_text_to_an_existing_file
    {
        public static void Main()
        {
            string fileName = @"mytest.txt";
            try
            {
                // Delete the file if it exists.
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                Console.Write("\n\n Append some text to an existing file  :\n");
                Console.Write("--------------------------------------------\n");
                // Create the file.
                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine(" Hello and Welcome");
                    fileStr.WriteLine(" It is the first content");
                    fileStr.WriteLine(" of the text file mytest.txt");
                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine(" Here is the content of the file mytest.txt : ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");
                }
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"mytest.txt", true))
                {
                    file.WriteLine(" This is the line appended at last line.");
                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine(" Here is the content of the file after appending the text : ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");
                }

            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
    }
}

