using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Sort_Search
{
   public class SortedMatrixSearch
    {
       static Coordinate FindElement(int[][] matrix, Coordinate origin, Coordinate dest, int x)
        {
            if (!origin.inbounds(matrix) || !dest.inbounds(matrix))
            {
                return null;


            }
            if (matrix[origin.row][origin.column] == x)
            {
                return origin;
            }
            else if (!origin.isBefore(dest))
            {
                return null;
            }
            /* Set start to start of diagonal and end to the end of the diagonal. Since the
           12 * grid may not be square, the end of the diagonal may not equal dest. */
            Coordinate start = (Coordinate)origin.Clone();

            int diagDist = Math.Min(dest.row - origin.row, dest.column - origin.column);
            Coordinate end = new Coordinate(start.row + diagDist, start.column + diagDist);
            Coordinate p = new Coordinate(0, 0);

            /* Do binary search on the diagonal, looking for the first element> x */
            while (start.isBefore(end))
            {
                p.setToAverage(start, end);
                if (x > matrix[p.row][p.column])
                {
                    start.row = p.row + 1;
                    start.column = p.column + 1;
                }
                else
                {
                    end.row = p.row - 1;
                    end.column = p.column - 1;
                }
            }

            /* Split the grid into quadrants. Search the bottom left and the top right. */
            return PartitionAndSearch(matrix, origin, dest, start, x);
        }

       static Coordinate PartitionAndSearch(int[][] matrix, Coordinate origin, Coordinate dest, Coordinate pivot, int x)
        {
            Coordinate lowerLeftOrigin = new Coordinate(pivot.row, origin.column);
            Coordinate lowerLeftDest = new Coordinate(dest.row, pivot.column - 1);
            Coordinate upperRightOrigin = new Coordinate(origin.row, pivot.column);
            Coordinate upperRightDest = new Coordinate(pivot.row - 1, dest.column);

            Coordinate lowerLeft = FindElement(matrix, lowerLeftOrigin, lowerLeftDest, x);
            if (lowerLeft == null)
            {
                return FindElement(matrix, upperRightOrigin, upperRightDest, x);
            }
            return lowerLeft;
        }

        Coordinate findElement(int[][] matrix, int x)
        {
            Coordinate origin = new Coordinate(0, 0);
            Coordinate dest = new Coordinate(matrix.Length - 1, matrix[0].Length - 1);
            return FindElement(matrix, origin, dest, x);
        }

        public class Coordinate : ICloneable
        {
            public int row, column;
            public Coordinate(int r, int c)
            {
                row = r;
                column = c;
            }

            public bool inbounds(int[][] matrix)
            {
                return row >= 0 && column >= 0 &&
                row < matrix.Length && column < matrix[0].Length;
            }

            public bool isBefore(Coordinate p)
            {
                return row <= p.row && column <= p.column;
            }

            public object Clone()
            {
                return new Coordinate(row, column);
            }

            public void setToAverage(Coordinate min, Coordinate max)
            {
                row = (min.row + max.row) / 2;
                column = (min.column + max.column) / 2;
            }
        }

        public static void Run()
        {
            int[][] arr = new int[][] { new int[] { 15, 20, 70,85 }, new int[] { 25, 35, 80,95 }, new int[] { 30, 55, 95,105 }, new int[] { 40, 80, 120, 120 } };
            var res=FindElement(arr,new Coordinate(0,0),new Coordinate(3,3),20);
        }
    }
}
