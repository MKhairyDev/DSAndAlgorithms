using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Sort_Search
{
    /*
     Search in Rotated Array: Given a sorted array of n integers that has been rotated an unknown
number of times, write code to find an element in the array. You may assume that the array was
originally sorted in increasing order.
EXAMPLE
lnput:find5in{15, 16, 19, 20, 25, 1, 3, 4, 5, 7, 10, 14}
Output: 8 (the index of 5 in the array)

     */
    public class SearchInRotatedArray
    {
        /*
         This code will run in O(log n) if all the elements are unique. However, with many duplicates, the algorithm
is actually O( n). This is because with many duplicates, we will often have to search both the left and
right sides of the array (or subarrays)
         */
       static int Search(int[] a, int left, int right, int x)
        {
            if (right < left)
            {
                return -1;

            }
            int mid = (left + right) / 2;
            if (a[mid] == x)
            {
                return mid;
            }
            /*
                Either the left or right half must be normally ordered.Find out which side
is normally ordered, and then use the normally ordered half to figure out
 which side to search to find x.
                */

            if (a[left] < a[mid])
            {
                if (a[left] <= x && x < a[mid])
                {
                    return Search(a, left, mid - 1, x);
                }
                else
                {
                    return Search(a, mid + 1, right, x);
                }
            }
            else if (a[left] > a[mid])
            {
                if (a[mid] < x && x <= a[right])
                {
                    return Search(a, mid + 1, right, x);
                }
                else
                {
                    return Search(a, left, mid - 1, x);
                }
            }
            else if (a[left] == a[mid])
            {
                if (a[mid] != a[right])
                {
                    return Search(a, mid + 1, right, x);
                }
                else
                {

                    var res = Search(a, left, mid - 1, x);
                    if (res == -1)
                    {
                        return Search(a, mid + 1, right, x);
                    }
                    else
                    {
                        return res;
                    }
                }
            }
            return -1;
        }
        public static void Run()
        {
        var res=    Search(new[] { 15, 16, 19, 20, 25, 1, 3, 4, 5, 7, 10, 14 },0,11,5);
        }
    }
}
