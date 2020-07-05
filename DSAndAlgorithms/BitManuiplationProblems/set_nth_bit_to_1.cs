using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BitManuiplationProblems
{
    /// <summary>
    /*
     */
    /// </summary>
   public class setNthBitTo1
    {
        public static int set_nth_bit_to_1(int num, int n)
        {
            int checkBit = 1 << n;
            int bitRes = num | checkBit;
            return bitRes;
        }
        public static void Run()
        {
            var res = set_nth_bit_to_1(3, 2);
        }
    }
}
