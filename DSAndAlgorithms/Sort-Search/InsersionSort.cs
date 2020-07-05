using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms
{
    /**
     * Created by jananiravi on 11/14/15.
     */
    public class InsertionSort
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

        public static void insertionSort(int[] listToSort)
        {
            for (int i = 0; i < listToSort.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (listToSort[j] < listToSort[j - 1])
                    {
                        swap(listToSort, j, j - 1);
                    }
                    else
                    {
                        break;
                    }
                    print(listToSort);
                }
            }
        }
    }

}
