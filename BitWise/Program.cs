using System;
using System.Linq;

namespace BitWise
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1; // 0001
            Console.WriteLine(1 << x);
            int c = 1; // 0001
            Console.WriteLine(x & (1 << c));
            Console.WriteLine("Hello World!");

            int[] maxInput = { 1, 2, 3, 4, 300, 100 };
            int res =  maxInput.OrderBy(y => y).Last();
            Console.WriteLine(res);
        }
    }
}