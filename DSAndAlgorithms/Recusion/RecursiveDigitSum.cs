using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Recusion
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/recursive-digit-sum/problem
    /// https://www.sjsu.edu/faculty/watkins/Digitsum.htm
    /// https://www.khanacademy.org/math/pre-algebra/pre-algebra-factors-multiples/pre-algebra-divisibility-tests/v/the-why-of-the-9-divisibility-rule
    /// </summary>
    public class RecursiveDigitSum
    {
        // Complete the superDigit function below.
        static int superDigit(string n, int k)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < k % 9; i++)
            {
                sb.Append(n);
            }
            return Helper(sb);
        }

        static int Helper(StringBuilder str)
        {
            if (str.Length == 1)
                return Convert.ToInt32(str.ToString());
            else
            {
                long sum = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    sum += Convert.ToInt32(str[i].ToString());
                }
                return Helper(new StringBuilder(sum.ToString()));
            }
        }
        public static void Run()
        {
            var res4 = superDigit("9875", 4);
            var res2 = superDigit("148", 3);
            var res3 = superDigit("123", 3);
        }
    }
}
