using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    class StoneDivisionProblem
    {
        static long stoneDivision(long n, long[] s)
        {
            Dictionary<long, long> dp = new Dictionary<long, long>();
           var res= solve(n, s, dp);
            return res;

        }
        private static long solve(long sizeOfPile, long[] querySet, Dictionary<long, long> dp)
        {

            if (sizeOfPile == 0 || sizeOfPile == 1)
            {
                return 0;
            }

            if (dp.ContainsKey(sizeOfPile))
            {
                return dp[sizeOfPile];
            }

            long max = 0;

            foreach (long query in querySet)
            {
                long sum = 0;
                if (sizeOfPile % query != 0 || sizeOfPile == query)
                {
                    continue;
                }

                long numberOfPiles = sizeOfPile / query;
                sum += solve(query, querySet, dp) * numberOfPiles;
                sum += 1;
                max = Math.Max(max, sum);
            }

            dp.Add( sizeOfPile, max);

            return max;
        }
        public static void Run()
        {
            var res=stoneDivision(12,new long[] { 2, 3, 4 });
        }
    }
}
