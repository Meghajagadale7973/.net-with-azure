using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main1(string[] args)
        {
            Example e1 = new Example("megha",23);
            e1.getData();
            Example e2 = new Example(e1);
            e2.getData();

            Console.ReadLine();


            
        }



    }
    class Example
    {
        string name;
        int age;

        public Example( string name,int age)
        {
            this.name = name;
            this.age = age;

        }

        public Example(Example e)
        {
            this.name = e.name;
            this.age = e.age;
        }
        public void getData()
        {
            Console.WriteLine("Name is:" + name);
            Console.WriteLine("age is:" + age);


        }
    }




}
