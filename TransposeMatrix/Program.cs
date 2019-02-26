using System;

namespace TransposeMatrix
{
    public class Solution
    {
        public int[][] Transpose(int[][] A)
        {
            int[][] B = new int[A[0].Length][];
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (i == 0)
                    {
                        B[j] = new int[A.Length];
                    }
                    B[j][i] = A[i][j];
                }
            }
            return B;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] matrix = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4,5,6}, new int[] { 7,8,9 } };
            int[][] matrix = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } };
            var result = new Solution().Transpose(matrix);
            foreach(var row in result)
            {
                foreach(var col in row)
                {
                    Console.Write(col + ", ");
                }
                Console.WriteLine("");
            }
        }
    }
}