using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    abstract class Animal
    {

        public abstract void eat();

        private string name;
        public void setname(string _name)
        {
            name = _name;
        }
       public String getName()
        {
            return name;
        }

    }
    class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("dog is eating");
        }

    }
    class test
    {
        public static void Main4(string[] args)
        {
            Dog d = new Dog();
            d.setname("tommy");
            Console.WriteLine(d.getName());
            d.eat();
        }
    }
}
