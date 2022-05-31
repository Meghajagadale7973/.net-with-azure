using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class person
    {
        private int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int _age)
        {
            age = _age;
        }
        class student : person
        {
            public void study()
            {
                Console.WriteLine("i am studying on the screen");
            }
            public void showAge(int age)
            {
                Console.WriteLine("my age is :" + age);

            }

        }
        class teacher : person

        {
            public void Explain()
            {
                Console.WriteLine("i am teaching on screen");
            }
            public void ShowAge()
            {
                Console.WriteLine("My age is : " + age);
            }


        }
        class studentprofessortest

        {
            static void Main4(string[] arg)
            {
                person p = new person();
                p.Greet();
                student s = new student();
                s.study();
                s.Greet();
                s.showAge(15); 

                teacher t = new teacher();
                t.SetAge(40);
                t.Greet();
                t.ShowAge();
                t.Explain();





            }

        }






















    }
}    
        

