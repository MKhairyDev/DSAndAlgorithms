using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BitManuiplationProblems
{
    /// <summary>
    /*
     The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

Given two integers x and y, calculate the Hamming distance.

Note:
0 ≤ x, y < 231.

Example:

Input: x = 1, y = 4

Output: 2

Explanation:
1   (0 0 0 1)
4   (0 1 0 0)
       ↑   ↑

The above arrows point to positions where the corresponding bits are different.
     */
    /// </summary>
    public class HammingDistanceProblem
    {
        /// <summary>
        /// Using Bit Manuiplation
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int HammingDistance(int x, int y)
        {
            int count=0;
            int res = x ^ y;
            while (res>0)
            {
                res = res & (res - 1);
                count++;
            }
            return count;
        }
        public static void Run()
        {
            var res=HammingDistance(1, 4);
            var res2 = HammingDistance(5, 8);
            var res3 = HammingDistance(6, 6);
        }
    }
}
