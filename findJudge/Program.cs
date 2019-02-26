using System;
using System.Collections.Generic;

namespace findJudge
{
    class Solution
    {
        public int findJudge(int N, int[][] trust)
        {
            if (N == 1) return 1;
            int[] count = new int[N + 1];
            int[] otherCount = new int[N + 1];
            foreach(int[] item in trust)
            {
                count[item[1]]++;
                otherCount[item[0]]++;
            }
            for(int i = 1; i < N + 1; i++)
            {
                if (count[i] == N - 1 && otherCount[i] == 0)
                    return i;
            }
            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            //var result = s.findJudge(2, new List<List<int>> { new List<int> { 1, 2 } });
            //var result = s.findJudge(3, new List<List<int>> { new List<int> { 1, 3 }, new List<int> { 2, 3 } });
            var result = s.findJudge(3, new int[][] { new int[] { 1, 2 }, new int[] { 1, 3 } });
            Console.WriteLine(result);
        }
    }
}
