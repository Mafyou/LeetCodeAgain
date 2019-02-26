using System;
using System.Collections.Generic;

namespace SorrayArrayPartyII
{
    public class Solution
    {
        public int[] SortArrayByParityII(int[] A)
        {
            int n = A.Length;
            var result = new int [n];
            for (int i = 0, even = 0, odd = 1; i < n; i++)
            {
                if (A[i] % 2 == 0)
                {
                    result[even] = A[i];
                    even += 2;
                }
                else
                {
                    result[odd] = A[i];
                    odd += 2;
                }
            }
            return result;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var result = s.SortArrayByParityII(new int[] { 4, 2, 5, 7 }); // 4,5,2,7
            //var result = s.SortArrayByParityII(new int[] { 3, 1, 4, 2 }); // 2,1,4,3
            //var result = s.SortArrayByParityII(new int[] { 888, 505, 627, 846 }); // [888,505,846,627]
            foreach (int num in result)
            {
                Console.Write(num + ", ");
            }
        }
    }
}
