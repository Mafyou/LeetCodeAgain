using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckRevealedIncreasing
{
    public class Solution
    {
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            int len = deck.Length;
            var orderedDeck = deck.OrderBy(x => x).ToList();
            List<int> answer = new List<int>();

            int i, j = 0;
            for (i = len - 2, j = 1; i >= (len/2); --i, ++j)
            {
                Console.WriteLine(orderedDeck[j - 1] + " - " + orderedDeck[i]);
                answer.Add(orderedDeck[j - 1]);
                answer.Add(orderedDeck[i]);
            }
            if (i % 2 == 0 && len > 2)
            {
                int tmp = orderedDeck[len - 1];
                int last = answer[answer.Count - 1];
                if (tmp < last)
                {
                    answer.RemoveAt(answer.Count - 1);
                    answer.Add(last);
                    answer.Add(tmp);
                }
                else
                {
                    answer.RemoveAt(answer.Count - 1);
                    answer.Add(tmp);
                    answer.Add(last);
                }
            }
            else if (i % 2 != 0 && len > 2)
            {
                answer.Add(orderedDeck[len - 3]);
                answer.Add(orderedDeck[len - 1]);
            }
            else
            {
                answer = orderedDeck.ToList();
            }

            int k = 0;
            int[] res = new int[answer.Count];
            foreach (int card in answer)
            {
                res[k++] = card;
            }
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            //var answer = s.DeckRevealedIncreasing(new int[] { 1, 2 }); // [1,2]
            //var answer = s.DeckRevealedIncreasing(new int[] { 17, 13, 11, 2, 3, 5, 7 }); // [2,13,3,11,5,17,7]
            var answer = s.DeckRevealedIncreasing(new int[] { 1, 2, 3, 4 }); // [1,3,4,0]
            foreach (var card in answer)
            {
                Console.Write(card + ", ");
            }
        }
    }
}