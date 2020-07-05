using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BitManuiplationProblems
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/flipping-bits/problem
    /// </summary>
    public class FlippingBitsProblem
    {
        static long flippingBits(long n)
        {
            uint checkBit=(uint)1<<(sizeof(int)*8)-1;
            while(checkBit>0)
            {
             n = (uint)(checkBit ^ n);
   
                checkBit = checkBit >> 1;
            } 
            return n;
        }
        public static void Run()
        {
            /*
            2147483648
            4294967294
            4294967295
            */
            var res =  flippingBits(2147483647);
            var res2 = flippingBits(1);
            var res3 = flippingBits(0);
        }
    }
}
