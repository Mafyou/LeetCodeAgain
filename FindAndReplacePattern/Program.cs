using System;
using System.Collections.Generic;
using System.Linq;

namespace FindAndReplacePattern
{
    public class Solution
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            IList<string> result = new List<string>();

            foreach(string word in words)
            {
                bool add = true;
                char oldLetterPattern = pattern[0];
                char oldLetterWord = word[0];
                for(int i = 0; i < word.Length; i++)
                {
                    if (oldLetterPattern == pattern[i] &&
                        oldLetterWord == word[i] ||
                        oldLetterPattern != pattern[i] &&
                        oldLetterWord != word[i])
                    {
                        oldLetterPattern = pattern[i];
                        oldLetterWord = word[i];
                    }
                    else
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                    result.Add(word);
            }

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var result = s.FindAndReplacePattern(new string[] {"abc", "deq", "mee", "aqq", "dkd", "ccc"}, "abb"); // ["mee","aqq"]

            result = s.FindAndReplacePattern(new string[] { "badc", "abab", "dddd", "dede", "dede", "yyxx" }, "baba"); // ["abab","dede"]
            foreach (var match in result)
            {
                Console.WriteLine(match);
            }
        }
    }
}
