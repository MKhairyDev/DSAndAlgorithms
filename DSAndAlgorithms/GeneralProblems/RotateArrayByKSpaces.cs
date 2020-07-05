using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.GeneralProblems
{
   public class RotateArrayByKSpaces
    {
        public static void RotateArraySolution1(int[]arr,int k)
        {
            int startIndex = (arr.Length - k) - 1;
            int iterativeIndex = 0;
            while(startIndex<arr.Length)
            {
                var temp = arr[iterativeIndex];
                arr[iterativeIndex] = arr[startIndex];
                arr[startIndex] = temp;
                iterativeIndex++;
                startIndex++;
            }
        }
        public static void Run()
        {
            int[] arr = new int[5] { 1,2,3,4,5};
            RotateArraySolution1(arr, 2);
        }
    }
}
