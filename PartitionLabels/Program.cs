using System;
using System.Collections.Generic;

namespace PartitionLabels
{
    public class Solution
    {
        public IList<int> PartitionLabels(string S)
        {
            List<int> answer = new List<int>();

            string label = string.Empty;
            bool isExists = false;
            for(int i = 0; i < S.Length; i++)
            {
                char current = S[i];
                if (label.Contains(current))
                {
                    label += current;
                    isExists = true;
                }
                else if (!isExists)
                {
                    label += current;
                }
                else
                {
                    answer.Add(label.Length);
                    isExists = false;
                    label = string.Empty;
                }
            }

            return answer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var answer = s.PartitionLabels("ababcbacadefegdehijhklij");
            foreach (int labelLength in answer)
            {
                Console.Write(labelLength + ", ");
            }
        }
    }
}