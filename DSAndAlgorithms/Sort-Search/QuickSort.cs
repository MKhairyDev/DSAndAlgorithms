using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms
{
    /**
   * Created by jananiravi on 11/15/15.
   */
    public class QuickSort
    {


        public static void print(int[] listToSort)
        {
            foreach (int el in listToSort)
            {
                Console.Write(el + ",");
            }
            Console.WriteLine();
        }

        public static void swap(int[] listToSort, int iIndex, int jIndex)
        {
            int temp = listToSort[iIndex];
            listToSort[iIndex] = listToSort[jIndex];
            listToSort[jIndex] = temp;
        }

        public static void quickSort(int[] listToSort, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int pivotIndex = partition(listToSort, low, high);
            quickSort(listToSort, low, pivotIndex - 1);
            quickSort(listToSort, pivotIndex + 1, high);
        }

        public static int partition(int[] listToSort, int low, int high)
        {
            int pivot = listToSort[low];
            int l = low;
            int h = high;
            while (l < h)
            {
                while (listToSort[l] <= pivot && l < h)
                {
                    l++;
                }
                while (listToSort[h] > pivot)
                {
                    h--;
                }
                if (l < h)
                {
                    swap(listToSort, l, h);
                }
            }
            swap(listToSort, low, h);

           Console.WriteLine("Pivot: " + pivot);
            print(listToSort);
            return h;
        }
    }

}
