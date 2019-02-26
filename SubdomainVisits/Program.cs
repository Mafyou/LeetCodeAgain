using System;
using System.Collections.Generic;
using System.Linq;

namespace SubdomainVisits
{
    public class Solution
    {
        private List<string> parseDomains(string domain)
        {
            var rtn = new List<string>();
            rtn.Add(domain);
            int start = 0;
            while (start < domain.Length)
            {
                if (domain[start++] == '.')
                {
                    rtn.Add(domain.Substring(start, domain.Length - start));
                }
            }
            return rtn;
        }

        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach(string cpdomain in cpdomains)
            {
                string[] visitedAndDomain = cpdomain.Split(' ');
                int hits = int.Parse(visitedAndDomain[0]);
                string domain = visitedAndDomain[1];

                foreach (string subdomain in parseDomains(domain))
                {
                    if (dict.ContainsKey(subdomain))
                        dict[subdomain] += hits;
                    else
                        dict.Add(subdomain, hits);
                }
            }

            IList<string> answer = new List<string>();
            foreach(KeyValuePair<string, int> item in dict)
            {
                answer.Add(string.Format("{0} {1}", item.Value, item.Key));
            }
            return answer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            IList<string> list = s.SubdomainVisits(new string[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" });
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}