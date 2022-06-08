using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{ 
    public class Shape
    {
        protected Location c;
        public string ToString()
        {
            return string.Empty;
        }
        public double perimeter()
        {
            return 0.00;
        }
        public Double area(){
            return 0.00;

        }


    }
    public class rectangle : Shape
    {
        protected double side1;
        protected double side2;
    }
    public class circle : Shape
    {
        protected double radius;


    }
    public class Location
    {
        private double x, y;
    }
    public class program
    {
        public static void Main3(String[] arg)
        {

        }
    }
}
    