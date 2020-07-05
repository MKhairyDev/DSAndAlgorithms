using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BitManuiplationProblems
{
    /// <summary>
    /*
     * https://www.hackerrank.com/challenges/counter-game/problem?h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
     */
    /// </summary>
    public class CounterGameProblem
    {
        // Complete the counterGame function below.
        static string CounterGame(long n)
        {
            var count = NumOfOnes(n - 1);
            if (count % 2 != 0)
                return "Louise ";
            else
                return "Richard";

        }
         static int NumOfOnes(long n)
        {
            int count = 0;
            while (n>0)
            {
                n = n & (n - 1);
                count++;
            }
            return count;
        }
        public static void Run()
        {
            var res= CounterGame(132);
            var res2 = CounterGame(6);
        }
    }
}
