using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.GeneralProblems
{
   public class AddtwoNumbersReferencedByTheirDigits
    {
        //Example: {1,2}+{2,3}={3,5}
        public static int[]AddNumbers(int[]num1,int[]num2)
        {
            List<int> digitList = new List<int>();
            int lastIndex1= num1.Length-1;
            int lastIndex2 = num2.Length - 1;
            int carrier = 0;
            while (lastIndex1>=0&&lastIndex2>=0)
            {
                var total = num1[lastIndex1] + num2[lastIndex2]+carrier;
                int digit = total % 10;
                carrier = total / 10;
                digitList.Insert(0,digit);
                lastIndex1--;
                lastIndex2--;

            }
            while(lastIndex1>=0)
            {
                var total = num1[lastIndex1] + carrier;
                int digit = total % 10;
                carrier = total / 10;
                digitList.Insert(0, digit);
                lastIndex1--;
            }
            while (lastIndex2 >= 0)
            {
                var total = num2[lastIndex1] + carrier;
                int digit = total % 10;
                carrier = total / 10;
                digitList.Insert(0, digit);
                lastIndex2--;
            }
            if(carrier!=0)
            {
                digitList.Insert(0, carrier);
            }
            return digitList.ToArray();
        }
    }
}
