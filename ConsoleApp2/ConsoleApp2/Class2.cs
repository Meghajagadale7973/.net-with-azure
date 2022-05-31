using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Shape
    {
         protected double length;
        protected  double width;
    }

        public class square : Shape
        {
        public square(double side)
        {
            length = width = side;
        }

        public void area()
            {
                Console.WriteLine("area of square:"+(length*width));
            }
        }
        public class rectangle : Shape
        {
        public rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
            public void area()
            {
                Console.WriteLine("area of rectangle:"+(length * width));
            }
        }


    
    class Class2
    {
        public static void Main3(String[] args)
        {

            rectangle r = new rectangle(2,5);
            r.area();
            square s = new square(2);
            s.area();
        }




    }

}