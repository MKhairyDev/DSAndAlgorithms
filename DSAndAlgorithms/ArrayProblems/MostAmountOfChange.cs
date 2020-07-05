using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Recusion
{
    public class MostAmountOfChange
    {
        /*
   You are in an infinite 2D grid where you can move in any of the 8 directions :

    (x,y) to 
       (x+1, y), 
       (x - 1, y), 
       (x, y+1), 
       (x, y-1), 
       (x-1, y-1), 
       (x+1,y+1), 
       (x-1,y+1), 
       (x+1,y-1) 
   You are given a sequence of points and the order in which you need to cover the points. Give the minimum number of steps in which you can achieve it. You start from the first point.

   Example :

   Input : [(0, 0), (1, 1), (1, 2)]
   Output : 2
   It takes 1 step to move from (0, 0) to (1, 1). It takes one more step to move from (1, 1) to (1, 2).

   */

        // Input : X and Y co-ordinates of the points in order. 
        // Each point is represented by (X[i], Y[i])
        /*Solution:
        Equation to get steps between two points is:
        Math.Max(Math.Abs(X1-x2),Math.Abs(y1-y2))
        */

        public static int CoverPoints(List<int> A, List<int> B)
        {
            int n = A.Count, count = 0;
            for (int i = 0; i < n - 1; i++)
            {

                count += Math.Max(Math.Abs(A[i] - A[i + 1]) , Math.Abs(B[i] - B[i + 1]));
            }
            return count;
        }

        public static void Run()
        {
            int res= CoverPoints(new List<int> { 0, 1, 1 }, new List<int> { 0, 1, 2 });
        }
       

    }
}
