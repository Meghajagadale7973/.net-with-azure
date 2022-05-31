using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Baseclass
    {
        public virtual void show()
        {
            Console.WriteLine("i am from base class");
        }
    }
        class Derivedclass : Baseclass
        {
            public override void show()
            {
                Console.WriteLine("i am from derived class");
            }
        }
    class mainapp1
    {


        public static void Main3(string[] args)
        {
            Derivedclass d = new Derivedclass();
            d.show();
            Baseclass b;
            b=new Baseclass();
            b.show();
            b = new Derivedclass();
            b.show();
        }
    }
}

