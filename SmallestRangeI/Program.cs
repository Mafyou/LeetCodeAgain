using System;
using System.Linq;

namespace SmallestRangeI
{
    public class Solution
    {
        public int SmallestRangeI(int[] A, int K)
        {
            int mini = A.Min() + K;
            int maxi = A.Max() - K;

            if (maxi < mini)
                return 0;

            return maxi - mini;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.SmallestRangeI(new int[] { 1 }, 0)); // 0
            Console.WriteLine(s.SmallestRangeI(new int[] { 0, 10 }, 2)); // 6
        }
    }
}
