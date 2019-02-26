using System;

namespace PlusOne
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            int carry = 1;
            int[] answer = new int[digits.Length];
            for(int i = digits.Length - 1; i >= 0; i--)
            {
                int sum = digits[i] + carry;
                if (sum == 10) carry = 1;
                else carry = 0;
                answer[i] = sum % 10;
            }
            if (carry == 1)
            {
                answer = new int[digits.Length + 1];
                answer[0] = carry;
            }
            return answer;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var result = s.PlusOne(new int[] { 9, 9, 9 });
            foreach(int num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
