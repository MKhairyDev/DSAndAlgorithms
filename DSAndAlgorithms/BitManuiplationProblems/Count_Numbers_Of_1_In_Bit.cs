using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BitManuiplationProblems
{
    /// <summary>
    /*
     */
    /// </summary>
   public class CountNumbersOf1InBit
    {
        public static int Count_Numbers_Of_1_In_Bit(int num)
        {
            //Time complexity is : O(number of 1s)
            int count = 0;
            while (num > 0)
            {
                num = num & (num - 1);
                count++;
            }
            return count;
        }
        public static void Run()
        {
         var res=   Count_Numbers_Of_1_In_Bit(30);
        }
    }
}
