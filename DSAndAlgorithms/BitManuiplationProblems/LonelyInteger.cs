using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BitManuiplationProblems
{
    /// <summary>
    /*
     https://www.hackerrank.com/challenges/lonely-integer/problem
     */
    /// </summary>
    public class LonelyIntegerProblem
    {
        static int lonelyinteger(int[] a)
        {
            int res = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                res = res ^ a[i];
            }
            return res;

        }
        public static void Run()
        {
            var res = lonelyinteger(new int[] { 1, 1, 2 });
            var res2 = lonelyinteger(new int[] { 1, 2, 3,3,1,2,5 });
        }
    }
}
