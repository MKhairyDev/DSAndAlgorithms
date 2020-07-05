using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Recusion
{
   public class ThePowerSumProblem
    {
        static int powerSum(int X, int N)
        {
            return checkRecursive(X, N, 1, 0);

        }

        // Function to check power 
        // representations recursively  
        static int checkRecursive(int x, int n,
                                  int curr_num,
                                  int curr_sum)
        {
            // Initialize number of ways to express  
            // x as n-th powers of different natural  
            // numbers  
            int results = 0;

            // Calling power of 'i' raised to 'n'  
            int p = (int)Math.Pow(curr_num, n);
            while (p + curr_sum < x)
            {
                // Recursively check all greater values of i  
                results += checkRecursive(x, n, curr_num + 1,
                                                p + curr_sum);
                curr_num++;
                p = (int)Math.Pow(curr_num, n); ;
            }

            // If sum of powers is equal to x  
            // then increase the value of result.  
            if (p + curr_sum == x)
                results++;

            // Return the final result  
            return results;
        }


        public static void Run()
        {
        }
    }
}
