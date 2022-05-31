using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{class propertiesInClass
    {
        public propertiesInClass(double r)
        {
            _radius = r;
        }
        private double _radius;
        private double _pi = 3.14;
        public double radius
        {
            get
            {
                return _radius;
            }
        }
        public void printCircumference()
        {
            Console.WriteLine(2 * _pi * radius);

        }



    }

    class Class1
    {
        public static void Main2(String[] args)
        {
            propertiesInClass p = new propertiesInClass(2.5);
            Console.WriteLine("radius is:" + p.radius);
            p.printCircumference();
        }
    }
}
