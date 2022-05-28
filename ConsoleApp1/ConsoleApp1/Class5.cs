using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class5
    {



        static void Main5(String[] args)
        {
            Employee[] employeelist = new Employee[3];
            for (int i = 0; i < employeelist.Length; i++)
            {
                Employee e = new Employee();
                e.getData();
                employeelist[i] = e;
            }

            for (int i = 0; i < employeelist.Length; i++)
            {
                employeelist[i].PrintData();
            }

        }
        class Employee
        {
            public string ename;
            public int eid;
            public String Egender;
            public int esalary;
            public string companyname;
           public Employee()
            {
                companyname = "capgemini";
            }

            ~ Employee()
            {

            }

            public void getData()
            {
                Console.WriteLine("Please enter employee details");
                Console.WriteLine("please enter employee name");
                ename = Console.ReadLine();
               Console.WriteLine("Please enter Eid");
               eid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Egender");
                Egender = Console.ReadLine();
                Console.WriteLine("Please enter Esalary");
                esalary = Convert.ToInt32(Console.ReadLine());

            }

            public void PrintData()
            {
                Console.WriteLine("Employee Details are");
                Console.WriteLine(ename);
                Console.WriteLine(eid);
                Console.WriteLine(Egender);
                Console.WriteLine(esalary);
                Console.WriteLine(companyname);

            }
        }
    }
}
