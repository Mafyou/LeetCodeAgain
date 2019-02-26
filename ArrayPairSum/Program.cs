using System;
using System.Linq;

namespace ArrayPairSum
{
    public class Solution
    {
        public int ArrayPairSum(int[] nums)
        {
            var n = nums.Length;
            var orderedNums = nums.OrderBy(x => x).ToList();
            var answer = 0;
            for(int i = 0; i < n; i += 2)
            {
                var tmp = Math.Min(orderedNums[i], orderedNums[i + 1]);
                answer += tmp;
            }
            return answer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var result = s.ArrayPairSum(new int[] { 1,4,3,2 });
            Console.WriteLine(result);
        }
    }
}