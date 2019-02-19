using System;
using System.Collections.Generic;
using System.Linq;

namespace numUniqueEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emails = {
                "test.email+alex@leetcode.com",
                "test.e.mail+bob.cathy@leetcode.com",
                "testemail+david@lee.tcode.com"
            };

            List<string> valideEmails = new List<string>();

            for(int i = 0; i < emails.Length; i++)
            {
                string email = emails[i];
                string username = email.Split('@')[0];
                if (username.Contains('.'))
                {
                    username = username.Replace(".", string.Empty);
                }
                if (username.Contains('+'))
                {
                    username = username.Split('+')[0] + "@" + email.Split('@')[1];
                }

                valideEmails.Add(username + email.Split('@')[1]);
            }
            int count = valideEmails.Distinct().Count();
            Console.WriteLine(count);
            Console.WriteLine("Hello World!");
        }
    }
}
