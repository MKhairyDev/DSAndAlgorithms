using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.ArrayProblems
{
    /*

Given a non-negative number represented as an array of digits,

add 1 to the number ( increment the number represented by the digits ).

The digits are stored such that the most significant digit is at the head of the list.

Example:

If the vector has [1, 2, 3]

the returned vector should be [1, 2, 4]

as 123 + 1 = 124.

 NOTE: Certain things are intentionally left unclear in this question which you should practice asking the interviewer.
For example, for this problem, following are some good questions to ask :
Q : Can the input have 0’s before the most significant digit. Or in other words, is 0 1 2 3 a valid input?
A : For the purpose of this question, YES
Q : Can the output have 0’s before the most significant digit? Or in other words, is 0 1 2 4 a valid output?
A : For the purpose of this question, NO. Even if the input has zeroes before the most significant digit.

*/
    public class AddOneToNumber
    {
       static List<int> PlusOne(List<int> A)
        {
            int carrier = 1;
            List<int> newList = new List<int>();
            int n = A.Count;
            for (int i = n-1; i >=0; i--)
            {
                int sum=0;
 
                    sum = A[i] + carrier ;
                    var digit = sum % 10;
                    carrier = sum / 10;
                    newList.Insert(0, digit);
                
            }
            if(carrier>0)
                newList.Insert(0, carrier);
            while( newList.Count>0)
            {
                if (newList[0] == 0)
                {
                    newList.RemoveAt(0);
                }
                else
                    break;

                
            }

            return newList;
        }
        public static void Run()
        {
            var res=PlusOne(new List<int> { 0, 0, 4 });
        }
    }
}
