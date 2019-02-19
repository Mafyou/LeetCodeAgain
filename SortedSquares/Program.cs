using System;
using System.Linq;

namespace SortedSquares
{
    public class Solution
    {
        public int[] SortedSquares(int[] A)
        {
            return A.Select(x => x * x).OrderBy(x => x).ToArray();
        }
    }
    class Program
    {
        static void printMe(int[] a)
        {
            foreach (int x in a)
                Console.Write(x + ", ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var toto = new Solution();
            var res = toto.SortedSquares(new int[] { -4, -1, 0, 3, 10 }); //[0,1,9,16,100]
            printMe(res);
            res = toto.SortedSquares(new int[] { -7, -3, 2, 3, 11 }); // [4,9,9,49,121]
            printMe(res);

            Console.WriteLine("Hello World!");
        }
    }
}
