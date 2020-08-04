using System;

namespace test_c4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 0;
            Console.WriteLine("input one line");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("inputed {0}",x);
        }
    }
}
