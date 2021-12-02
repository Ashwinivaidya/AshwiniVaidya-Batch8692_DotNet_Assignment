using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystr, rev;
            mystr = "ashu";
            rev = "";
            Console.WriteLine("my srting is  {o}", mystr);
            int len;
            len = mystr.Length-1;
            while(len>=0)

            {
                rev = rev + mystr[len];
                len--;

            }
            Console.WriteLine("my srting is  {o}", rev);

        }
    }
}
