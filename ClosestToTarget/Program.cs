using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosestToTarget
{
    class Program
    {
        private const int INIT_VALUE = -1;

        static int[] ClosestToTarget_First(int[] a, int[] b, int target)
        {
            List<int> result = new List<int>(2);
            int i = 0;
            int sticky = a[0] + b[0];
            foreach (int na in a)
            {
                int tempTarget = na + b[i];
                if (Math.Abs(target - tempTarget) <= Math.Abs(target - sticky))
                {
                    result.Clear();
                    result.Add(na);
                    result.Add(b[i]);
                    sticky = tempTarget;
                }
                i++;
            }
            return result.ToArray();
        }

        static int[] ClosestToTarget_Second(int[] a, int[] b, int target)
        {
            List<int> result = new List<int>(2);
            int i = 0;
            int sticky = target - a[0] - b[0];
            foreach (int na in a)
            {
                int newAim = target - na - b[i];
                if (Math.Min(newAim, sticky) != sticky)
                {
                    result.Clear();
                    result.Add(na);
                    result.Add(b[i]);
                    sticky = newAim;
                }
                i++;
            }
            return result.ToArray();
        }

        static List<Tuple<int,int>> ClosestToTarget_Third(int[] a, int[] b, int target)
        {
            int n = a.Length;
            int minDiff = INIT_VALUE;

            a = a.OrderBy(x => x).ToArray();
            b = b.OrderBy(x => x).ToArray();

            int loops = 0;
            int miniX = 0;
            List<Tuple<int, int>> result = new List<Tuple<int, int>>();
            for (int y = n - 1; y > 0; y--)
            {
                for (int x = miniX; x < n; x++)
                {
                    int newTarget = a[y] + b[x];
                    int diffTarget = Math.Abs(newTarget - target);
                    if (minDiff == INIT_VALUE) minDiff = diffTarget;
                    if (diffTarget < minDiff)
                    {
                        result = new List<Tuple<int, int>>
                        {
                            new Tuple<int, int>(a[y], b[x])
                        };
                        minDiff = diffTarget;
                    }
                    else if (diffTarget == minDiff)
                    {
                        result.Add(new Tuple<int, int>(a[y], b[x]));
                        minDiff = diffTarget;
                    }
                    // x = n to end xloop cause to big already
                    if (newTarget > target) x = n;
                    // miniX = x to begin more closely to the target
                    else if (newTarget < target) miniX = x;
                    loops++;
                }
                loops++;
            }
            Console.WriteLine("Loops made: " + loops);
            return result;
        }

        static void Main(string[] args)
        {
            int[] a = { -1, 3, 8, 2, 9, 5 };
            int[] b = { 4, 1, 16, 10, 5, 1 };
            int target = 24;

            //Console.WriteLine(string.Join('+', ClosestToTarget_First(a, b, target)));
            //Console.WriteLine(string.Join('+', ClosestToTarget_Second(a, b, target)));
            //Console.WriteLine(string.Join('+', ClosestToTarget_Third(a, b, target)));

            a = new int[] { 7, 4, 1, 10 };
            b = new int[] { 4, 5, 8, 7 };
            target = 13;
            var res = ClosestToTarget_Third(a, b, target);
            foreach (Tuple<int, int> tulple in res)
            {
                Console.WriteLine(tulple.Item1 + " + " + tulple.Item2);
            }
        }
    }
}