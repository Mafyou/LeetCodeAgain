using System;
using System.Numerics;

namespace ComplexMultiplication
{
    public class Solution
    {
        public string ComplexNumberMultiply(string a, string b)
        {
            int numReal = int.Parse(a.Split('+')[0]);
            int numImg = int.Parse(a.Split('+')[1].Split('i')[0]);
            Complex num1 = new Complex(numReal, numImg);

            numReal = int.Parse(b.Split('+')[0]);
            numImg = int.Parse(b.Split('+')[1].Split('i')[0]);
            Complex num2 = new Complex(numReal, numImg);
            Complex result = num1 * num2;
            return string.Format("{0}+{1}i", result.Real, result.Imaginary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "1+1i";
            //string b = "1+1i";
            string a = "1+-1i";
            string b = "1+-1i";
            Console.WriteLine(new Solution().ComplexNumberMultiply(a, b));
        }
    }
}