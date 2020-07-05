using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BitManuiplationProblems
{
    /// <summary>
    /*
     * https://www.hackerrank.com/challenges/maximizing-xor/problem?h_r=next-challenge&h_v=zen
     */
    /// </summary>
    public class MaximizingXORProblem
    {
        static int maximizingXor(int l, int r)
        {
            int max = 0;
            for (int i = l; i <= r; i++)
            {
                for (int j = l; j <= r; j++)
                {
                 max= Math.Max((i ^ j),max);
                }
            }
            return max;
        }
        public static void Run()
        {
          var res=  maximizingXor(10,15);
        }
    }
}
