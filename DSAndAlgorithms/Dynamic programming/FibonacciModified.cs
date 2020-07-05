using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Dynamic_programming
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/fibonacci-modified/problem
    /// </summary>
    public class FibonacciModifiedProblem
    {
       static int num = 0;
        static System.Numerics.BigInteger fibonacciModified(int t1, int t2, int n)
        {


            System.Numerics.BigInteger[] arr = new System.Numerics.BigInteger[n];
            arr[0] = t1;
            arr[1] = t2;
            for (int i = 2; i < n; i++)
            {
                arr[i] = arr[i-2] + (arr[i - 1] * arr[i-1]);
            }
            return arr[arr.Length - 1];

        }

        public static void Run()
        {
            var res2=fibonacciModified(0, 1, 10);
            var res=fibonacciModified(0, 1, 5);
        }
    }
}
