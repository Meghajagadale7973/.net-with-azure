using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Calculator
    {
        public int number1, number2;
        public Calculator(int num1,int num2)
        {
            number1 = num1;
            number2 = num2;
        }
       public void print()
        {
            Console.WriteLine("number1:" + number1);
            Console.WriteLine("number2:" + number2);
        }
          public static Calculator operator *(Calculator c1, Calculator c2)
        {
            Calculator c3 = new Calculator(0,0);
            c3.number1 = c1.number1 * c2.number1;
            c3.number2 = c1.number2 *c2.number2;
            return c3;

        }
    public static void Main2(String[] args)
    {
        Calculator calculator1 = new Calculator(15, 25);
        Calculator calculator2 = new Calculator(10,15);
        Calculator calculator3 = new Calculator(0, 0);
        calculator3 = calculator1 * calculator2;
        calculator3.print();




    }
    


    }
}
