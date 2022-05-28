using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        static void Main3(String[] args)
        {
            Console.WriteLine("enter a string");
            string a1 = Console.ReadLine();
            string rev = "";
            for(int i = a1.Length - 1; i >= 0; i--)
            {
                rev = rev + a1[i];
            }
            Console.WriteLine("reverse string is:"+rev);
            Console.ReadLine();
        }
    }
}
