using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/kangaroo/problem?h_r=next-challenge&h_v=zen
    /// </summary>
    class Kangaroo
    {
/*
 * Math
 If v1<v2 they will never meet
 we just need to check if a solution existd for the following equation
 x1+t*v1==x2+t*v2
 This equivalent to checking if(x2-v1)%(v1-v2)==0
 */
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 <= v2)
                return "NO";
          return  (x2 - x1) % (v1 - v2) == 0 ? "YES" : "NO";
        }
            /// <summary>
            /// brute Force
            /// </summary>
            /// <param name="x1"></param>
            /// <param name="v1"></param>
            /// <param name="x2"></param>
            /// <param name="v2"></param>
            /// <returns></returns>
            static string kangaroo2(int x1, int v1, int x2, int v2)
        {
            if (v1 > v2)
            {

                while (x2 > x1)
                {
                    x1 += v1;
                    x2 += v2;
                    if (x1 == x2)
                        return "YES";
                }
            }
            return "NO";

        }
        public static void Run()
        {
            var res = kangaroo(43, 2, 70, 2);
            var res2 = kangaroo(0, 3, 4, 2);
            var res3 = kangaroo(0, 2, 5, 3);
        }
    }
}
