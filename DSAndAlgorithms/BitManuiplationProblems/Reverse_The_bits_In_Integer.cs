using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BitManuiplationProblems
{
    /// <summary>
    /*
     */
    /// </summary>
   public class ReverseThebitsInInteger
    {
        public static int Reverse_The_bits_In_Integer(int num)
        {
            int reverseNum = 0;
            uint count = (sizeof(int) * 8) - 1;
            while (num != 0)
            {
                int last_bit = num & 1;
                reverseNum = reverseNum | last_bit;
                reverseNum = reverseNum << 1;
                num = num >> 1;
                count--;
            }
            reverseNum = reverseNum << (int)count;
            return reverseNum;
        }
        public static void Run()
        {
           
          var  res = Reverse_The_bits_In_Integer(3);
       
        }
    }
}
