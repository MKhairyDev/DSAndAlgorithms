using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BitManuiplationProblems
{
    /// <summary>
    /*
     */
    /// </summary>
   public class SetNthBitTo0
    {
        public static int set_nth_bit_to_0(int num, int n)
        {
            int checkBit = 1 << n;
            checkBit = ~checkBit;
            int res = num & checkBit;
            return res;

        }
        public static void Run()
        {
            var res = set_nth_bit_to_0(3, 1);
        }
    }
}
