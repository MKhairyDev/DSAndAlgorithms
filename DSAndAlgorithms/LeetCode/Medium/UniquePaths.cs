using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Medium
{
    /// <summary>
    /*
     A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).

The robot can only move either down or right at any point in time. The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).

How many possible unique paths are there?


Above is a 7 x 3 grid. How many possible unique paths are there?

 

Example 1:

Input: m = 3, n = 2
Output: 3
Explanation:
From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
1. Right -> Right -> Down
2. Right -> Down -> Right
3. Down -> Right -> Right
Example 2:

Input: m = 7, n = 3
Output: 28
 

Constraints:

1 <= m, n <= 100
It's guaranteed that the answer will be less than or equal to 2 * 10 ^ 9.
     */
    /// </summary>
    public class UniquePathsProblem
    {
        public static int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;
            if (obstacleGrid[0][0] == 1)
            {
                return 0;
            }
            obstacleGrid[0][0] = 1;
            //Filling the value for the first row
            for (int i = 1; i < n; i++)
            {
                obstacleGrid[0][i]=    obstacleGrid[0][i] == 1 ? 0 : obstacleGrid[0][i - 1];
            }
            //Filling the value for the first column
            for (int i = 1; i < m; i++)
            {
                obstacleGrid[i][0] = obstacleGrid[i][0] == 1 ? 0 : obstacleGrid[i-1][0];
            }
            // Starting from cell(1,1) fill up the values
            // No. of ways of reaching cell[i][j] = cell[i - 1][j] + cell[i][j - 1]
            // i.e. From above and left.
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (obstacleGrid[i][j] == 1)
                    {
                        obstacleGrid[i][j] = 0;

                    }
                    else
                    {
                        obstacleGrid[i][j] = obstacleGrid[i][j - 1] + obstacleGrid[i - 1][j];
                    }
                }
            }
            return obstacleGrid[m - 1][ n - 1];
        }
        public static int UniquePaths(int m, int n)
        {
          var count= UniquePathsDynamicArray(m, n);
            return count;
        }
        private static int UniquePathsDynamicArray(int m, int n)
        {
            int[,] matrixArr = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixArr[i, j] = i == 0 || j == 0 ? 1 : matrixArr[i, j - 1] + matrixArr[i - 1, j];
                }
            }
            return matrixArr[m - 1, n - 1];

        }
        
            private static int UniquePathsRecursion(int m, int n, int rowEnd, int colEnd)
        {
            int count = 0;
            if (m == rowEnd - 1 && n == colEnd - 1)
            {
               // vistedCells[m, n] = -1;
                return 1;
            }
            if (m > rowEnd - 1 || n > colEnd - 1)
                return 0;
                count += UniquePathsRecursion(m + 1, n, rowEnd, colEnd);
            

                count += UniquePathsRecursion(m, n + 1, rowEnd, colEnd);
            
            return count;
        }
        public static void Run()
        {
            var res6 = UniquePathsWithObstacles(new int[3][] { new int[] { 0, 0,0 }, new int[] { 0, 1,0 }, new int[] { 0, 0,0 } });
            var res5 = UniquePathsWithObstacles(new int[3][] { new int[] { 0,0} , new int[] { 1, 1 } , new int[] { 0, 0 } });
            var res3 = UniquePathsWithObstacles(new int[1][] { new int[] { 0,1} });
            var res4 = UniquePathsWithObstacles(new int[1][] { new int[] {  1,0 } });
            var res = UniquePaths(3,2);
            var res2 = UniquePaths(7, 3);
        }
    }
}
