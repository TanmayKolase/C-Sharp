using System;

namespace Polymorphism
{
    class Parent
    {
        public virtual void fun()
        {
            Console.WriteLine("fun method of parent class");
        }
    }

    class Child
    {
        public override void fun()
        {
            Console.WriteLine("fun method of child class");
        }

        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.fun();
        }
    }
}