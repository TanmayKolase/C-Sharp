namespace Polymorphism
{
    class Program
    {
        void addition(int x , int y)
        {
            Console.WriteLine(x+y);
        }

        void addition(int x, int y , int z)
        {
            Console.WriteLine(x + y + z);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.addition(10,20);
            obj.addition(10, 20 , 30);
        }
    }
}