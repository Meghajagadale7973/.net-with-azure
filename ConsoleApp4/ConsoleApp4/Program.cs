using System;

namespace ConsoleApp4
{
    class Program
    {
        static void add()
        {
            int sum = 4 + 5;
            Console.WriteLine("additin:" + sum);


        }
        static void add(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine("addition is:" + sum);

        }
        static void add(int a,int b,int c)
        {
            int sum = a + b + c;
            Console.WriteLine("additon is" + sum);
        }
        public static void add(string a,string b)
        {
            int sum = Convert.ToInt32( a) + Convert.ToInt32(b);
            Console.WriteLine(sum);

        }




        static void Main1(string[] args)
        {
            add();
            add(2, 5);
            add(15, 25, 50);
            add("1", "2");
           
        }
    }
}
