using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.LeetCode.Easy
{
    /// <summary>
    /*
     You are given an array coordinates, coordinates[i] = [x, y], where [x, y] represents the coordinate of a point. Check if these points make a straight line in the XY plane.





Example 1:



Input: coordinates = [[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]
Output: true
Example 2:



Input: coordinates = [[1,1],[2,2],[3,4],[4,5],[5,6],[7,7]]
Output: false


Constraints:

2 <= coordinates.length <= 1000
coordinates[i].length == 2
-10^4 <= coordinates[i][0], coordinates[i][1] <= 10^4
coordinates contains no duplicate point.
     */
    /// </summary>
    public class CheckStraightLineProblem
    {
        public static bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates.Length == 2)
            {
                return true;
            }
            double basicSlope = GetSlope(coordinates[0][0], coordinates[0][1], coordinates[1][0], coordinates[1][1]);
            if (basicSlope == int.MaxValue)
                return false;
            int r = coordinates.Length;

            for (int i = 2; i < r; i++)
            {

                double currentSlope = GetSlope(coordinates[i - 1][0], coordinates[i - 1][1], coordinates[i][0], coordinates[i][1]);
                if (currentSlope != basicSlope)
                    return false;
            }
            return true;
        }
        private static double GetSlope(double x1, double y1, double x2, double y2)
        {
            double subX = x2 - x1;
            if (subX == 0)
                return int.MaxValue;
            double ySum = y2 - y1;
            double slope = ySum/ subX;
            return slope;
        }
        public static void Run()
        {
            //[[-4,-3],[1,0],[3,-1],[0,-1],[-5,2]]
            var res4 = CheckStraightLine(new int[][] { new int[] { -4, -3 }, new int[] { 1, 0 }, new int[] { 3, -1 },
            new int[] { 0, -1 }, new int[] { -5, 2 } });

            var res3 = CheckStraightLine(new int[][] { new int[] { -3, -2 }, new int[] { -1, -2 }, new int[] { 2, -2 },
            new int[] { -2, -2 }, new int[] { 0, -2 } });

            var res = CheckStraightLine(new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 },
            new int[] { 4, 5 }, new int[] { 5, 6 }, new int[] { 6, 7 } });

            var res2 = CheckStraightLine(new int[][] { new int[] { 1, 1 }, new int[] { 2, 2 }, new int[] { 3, 4 },
            new int[] { 4, 5 }, new int[] { 5, 6 }, new int[] { 6, 7 } });
        }
    }
}
