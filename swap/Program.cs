using System;

namespace swap
{
    class Program
    {
        public static void takas(int a, int b)
        {
            int t;
            t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;

            Console.WriteLine("\n" + "a:" +a);
            Console.WriteLine("\n" + "b:" + b);
        }
    }
}
