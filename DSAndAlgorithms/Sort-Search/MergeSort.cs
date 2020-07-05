using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms
{
    /**
   * Created by jananiravi on 11/15/15.
   */
    public class MergeSort
    {

   

        public static void print(int[] listToSort)
        {
            foreach (int el in listToSort)
            {
                Console.Write(el + ",");
            }
            Console.WriteLine();
        }

        public static void mergeSort(int[] listToSort)
        {
            if (listToSort.Length == 1)
            {
                return;
            }

            int midIndex = listToSort.Length / 2 + listToSort.Length % 2;
            int[] listFirstHalf = new int[midIndex];
            int[] listSecondHalf = new int[listToSort.Length - midIndex];
            split(listToSort, listFirstHalf, listSecondHalf);

            mergeSort(listFirstHalf);
            mergeSort(listSecondHalf);

            merge(listToSort, listFirstHalf, listSecondHalf);
            print(listToSort);
        }

        public static void split(int[] listToSort, int[] listFirstHalf, int[] listSecondHalf)
        {
            int index = 0;
            int secondHalfStartIndex = listFirstHalf.Length;
            foreach (int elements in listToSort)
            {
                if (index < secondHalfStartIndex)
                {
                    listFirstHalf[index] = listToSort[index];
                }
                else
                {
                    listSecondHalf[index - secondHalfStartIndex] = listToSort[index];
                }
                index++;
            }
        }

        public static void merge(int[] listToSort, int[] listFirstHalf, int[] listSecondHalf)
        {
            int mergeIndex = 0;
            int firstHalfIndex = 0;
            int secondHalfIndex = 0;

            while (firstHalfIndex < listFirstHalf.Length && secondHalfIndex < listSecondHalf.Length)
            {
                if (listFirstHalf[firstHalfIndex] < listSecondHalf[secondHalfIndex])
                {
                    listToSort[mergeIndex] = listFirstHalf[firstHalfIndex];
                    firstHalfIndex++;
                }
                else if (secondHalfIndex < listSecondHalf.Length)
                {
                    listToSort[mergeIndex] = listSecondHalf[secondHalfIndex];
                    secondHalfIndex++;
                }
                mergeIndex++;
            }

            if (firstHalfIndex < listFirstHalf.Length)
            {
                while (mergeIndex < listToSort.Length)
                {
                    listToSort[mergeIndex++] = listFirstHalf[firstHalfIndex++];
                }
            }
            if (secondHalfIndex < listSecondHalf.Length)
            {
                while (mergeIndex < listToSort.Length)
                {
                    listToSort[mergeIndex++] = listSecondHalf[secondHalfIndex++];
                }
            }
        }

    }

}
