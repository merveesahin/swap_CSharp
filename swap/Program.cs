using System;

namespace swap
{
    class Program
    {
        public static void takas(ref int a, ref int b)
        {
            //a = 3; out ile yapılırsa
            //b = 5; out ile yapılırsa
            int t;
            t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args)
        {
            //int a; out ile yapılırsa
            //int b; out ile yapılırsa
            int a = 3;
            int b = 5;
            takas(ref a, ref b);

            Console.WriteLine("\n" + "a:" +a);
            Console.WriteLine("\n" + "b:" + b);
        }
    }
}
