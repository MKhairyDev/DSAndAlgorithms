using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.ArrayProblems
{
    /// <summary>
    /*
     1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 0 0 0 0
0 0 0 0 0 0
0 0 0 0 0 0
We define an hourglass in  to be a subset of values with indices falling in this pattern in 's graphical representation:

a b c
  d
e f g
There are  hourglasses in , and an hourglass sum is the sum of an hourglass' values. Calculate the hourglass sum for every hourglass in , then print the maximum hourglass sum.

For example, given the 2D array:

-9 -9 -9  1 1 1 
 0 -9  0  4 3 2
-9 -9 -9  1 2 3
 0  0  8  6 6 0
 0  0  0 -2 0 0
 0  0  1  2 4 0
We calculate the following  hourglass values:

-63, -34, -9, 12, 
-10, 0, 28, 23, 
-27, -11, -2, 10, 
9, 17, 25, 18
Our highest hourglass value is  from the hourglass:

0 4 3
  1
8 6 6
Note: If you have already solved the Java domain's Java 2D Array challenge, you may wish to skip this challenge.

Function Description

Complete the function hourglassSum in the editor below. It should return an integer, the maximum hourglass sum in the array.

hourglassSum has the following parameter(s):

arr: an array of integers
Input Format

Each of the  lines of inputs  contains  space-separated integers .

Constraints

Output Format

Print the largest (maximum) hourglass sum found in .

Sample Input

1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 2 4 4 0
0 0 0 2 0 0
0 0 1 2 4 0
Sample Output

19
     */
    /// </summary>
    static class HourGlass2D
    {
        static int hourglassSum(int[][] arr)
        {
            int maxSum = int.MinValue;
            for (int r = 0; r < arr.Length-2; r++)
            {
                var currentSum = 0;
                for (int col = 0; col < arr[0].Length-2; col++)
                {
              
                        currentSum = arr[r][col] + arr[r][col + 1] + arr[r][col + 2] + arr[r + 1][col + 1]
                       + arr[r + 2][col] + arr[r + 2][col + 1] + arr[r + 2][col + 2];

                    maxSum = Math.Max(maxSum, currentSum);
                }
              
            }
            return maxSum;

        }

        public static void Run()
        {
        var res= hourglassSum(new int[][]{ new int []{1,1,1,0,0,0},new int [] {0,1,0,0,0,0 }, new int []{1,1,1,0,0,0 },
                new int [] {0,0,2,4,4,0 }, new int [] {0,0,0,2,0,0 }, new int [] {0,0,1,2,4,0 }  });
        }
    }
}
