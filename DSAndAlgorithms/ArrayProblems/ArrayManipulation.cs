using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.ArrayProblems
{
    /// <summary>
    /*
     https://www.hackerrank.com/challenges/crush/problem?h_r=next-challenge&h_v=zen
     */
    /// </summary>

    public class ArrayManipulationProblem
    {
        //O(n)

        static long ArrayManipulation(int n, int[][] queries)
        {
            long[] arr = new long[n+1];
            long max = long.MinValue;
            for (int i = 0; i < queries.Length; i++)
            {
                int start = queries[i][0] - 1;
                int end = queries[i][1] - 1;
                int val = queries[i][2];

            
                    arr[start] += val;
                arr[end+1] += -val;
             
                  
                
            }
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                max = Math.Max(sum, max);
            }
                
            return max;
        }
        // Brute-Force O(m*n)
        static long ArrayManipulation2(int n, int[][] queries)
        {

            long[] arr = new long[n];
            long max = long.MinValue;
            for (int i = 0; i < queries.Length; i++)
            {
                int start = queries[i][0] - 1;
                int end = queries[i][1] - 1;
                int val = queries[i][2];

                while (start <= end)
                {
                    arr[start] += val;
                    max = Math.Max(arr[start], max);
                    start++;
                }
            }
            return max;
        }
        public static void Run()
        {
         var res=   ArrayManipulation(5,new int[][] { new int[] { 1, 2, 100 }, new int[] { 2, 5, 100 }, new int[] { 3, 4, 100 } });
        }
    }
}
