using System;

namespace Polymorphism
{
    class Parent
    {
        int x;
        public Parent(int x)
        {
            this.x = x;
        }

        //Operator overloading
        public static Parent operator +(Parent obj1, Parent obj2)
        {
            return new Parent(obj1.x + obj2.x);
        }

        // Override ToString method
        public override string ToString()
        {
            return x.ToString();
        }
    }

    class Child : Parent
    {
        public Child(int x) : base(x) { }

        static void Main(string[] args)
        {
            Parent obj1 = new Parent(10); //10
            Parent obj2 = new Parent(20); //20

            Parent obj3 = obj1 + obj2; //call to Operator overloading
            Console.WriteLine(obj3); // Calls ToString method
        }
    }
}
