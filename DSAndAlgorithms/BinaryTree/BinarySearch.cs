using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms
{
    public class BinarySearch
    {
        public static int binarySearch(int[] sortedArray, int number, int min, int max)
        {

            if (min > max)
            {
                return -1;
            }

            int mid = min + (max - min) / 2;
            if (sortedArray[mid] == number)
            {
                return mid;
            }

            if (sortedArray[mid] > number)
            {
                return binarySearch(sortedArray, number, min, mid - 1);
            }
            else
            {
                return binarySearch(sortedArray, number, mid + 1, max);
            }
        }
    }
}
