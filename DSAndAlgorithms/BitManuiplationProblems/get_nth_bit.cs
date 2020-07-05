using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms
{
    public class GetNthBit
    {
        //b&0=0
        //b|0=b
        //b^0=b
        //b&1=b
        //b|1=1
        //b^1=~b
        //b&b=b
        //b&b=b
        //b|b=b
        //b^b=0
        /// <summary>
        /// Checks the Nth bit in an integer
        /// </summary>
        /// <param name="num"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int get_nth_bit(int num, int n)
        {
            int checkBit = 1 << n;
            int bitRes = num & checkBit;
            if (bitRes == checkBit)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static void Run()
        {
            var res=get_nth_bit(3, 1);
        }







    }
}
