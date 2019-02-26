using System;
using System.Linq;

namespace FlipAndInvertImage
{
    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            return doAFlipAndInvert(A);
        }

        private int[][] doAFlipAndInvert(int[][] a)
        {
            for (int step = 0; step < a.Length; step++)
            {
                int n = a[step].Length;
                int[] insertRow = new int[n];
                for (int row = 0; row < n; row++)
                {
                    insertRow[n - row - 1] = a[step][row] == 1 ? 0 : 1;
                }
                a[step] = insertRow;
            }            
            return a;
        }

        public void PrintMe(int[][] b)
        {
            Console.WriteLine("**************");
            foreach (var item in b)
            {
                foreach (var element in item)
                {
                    Console.Write(element + ", ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("**************");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            /*
             * Output: [[1,0,0],[0,1,0],[1,1,1]]
             * Explanation: First reverse each row: [[0,1,1],[1,0,1],[0,0,0]].
             * Then, invert the image: [[1,0,0],[0,1,0],[1,1,1]]*/
            var result = s.FlipAndInvertImage(new int[][] { new int[] { 1, 1, 0 }, new int [] { 1, 0, 1 }, new int[] { 0, 0, 0 } });
            s.PrintMe(result);

            /*
             * Output: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
             * Explanation: First reverse each row: [[0,0,1,1],[1,0,0,1],[1,1,1,0],[0,1,0,1]].
             * Then invert the image: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
             * 
             */
            result = s.FlipAndInvertImage(new int[][] { new int[] { 1, 1, 0, 0 }, new int[] { 1, 0, 0, 1 }, new int[] { 0, 1, 1, 1 }, new int[] { 1, 0, 1, 0 } });
            s.PrintMe(result);
        }
    }
}