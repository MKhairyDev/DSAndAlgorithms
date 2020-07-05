using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.BitManuiplationProblems
{
    /// <summary>
    /*
     */
    /// </summary>
   public class PrintBitsInInteger
    {
        public static void Print_Bits_In_Integer(int num)
        {
            uint checkBit = (uint)1 << (sizeof(int) * 8) - 1;
            while (checkBit > 0)
            {
                int bitRes = (int)checkBit & num;
                if (bitRes == checkBit)
                {
                    Console.Write(1);
                }
                else
                {
                    Console.Write(0);
                }
                checkBit = checkBit >> 1;
            }


        }
        public static void Run()
        {
            Print_Bits_In_Integer(3);
        }
    }
}
