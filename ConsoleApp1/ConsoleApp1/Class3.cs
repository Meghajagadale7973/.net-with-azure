using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class3
    {
        static void Main4(String[] args)
        {
            Employee e1 = new Employee();
            e1.ename = "megha";
            e1.eid = 101;
            e1.egender = "female";
            e1.esalary = 30000;
            Console.WriteLine("EMPOLYEE DEATails are");
            Console.WriteLine(e1.ename);
            Console.WriteLine(e1.eid);
            Console.WriteLine(e1.egender);
            Console.WriteLine(e1.esalary);





        }
    }
    class Employee
    {
        public string ename;
        public int eid;
        public string egender;
        public int esalary;
    }
}
