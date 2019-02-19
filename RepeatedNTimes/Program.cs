using System;

namespace RepeatedNTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 3 };
            int n = A.Length;
            if (n == 0) return;
            //int res = A.Where(x => {
            //    if (A.Count(y => x == y) > 1)
            //        return true;
            //    return false;
            //    }).ToArray()[0];
            var res = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int current = A[i];
                if (Array.FindAll(A, x => x == current).Length > 1)
                {
                    res = A[i];
                    break;
                }
            }
            Console.WriteLine(res);
        }
    }
}