using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.GeneralProblems
{
   public class GameOfLife
    {
        public static int[,]GetNextInteration(int[,] current)
        {
            int rowLength = current.GetLength(0);
            int colLength = current.GetLength(1);
            int[,] nextGenerationArr = new int[rowLength, colLength];
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    nextGenerationArr[i,j]= GetGameState(i, j, current);
                }
            }
            return nextGenerationArr;
        }
        private static int GetGameState(int row, int col, int[,] current)
        {
            int liveCount = 0;
            int lastIndex = current.GetLength(0) - 1;
            if(row>0&&col>0)
            {
                liveCount+= current[row-1,col-1];
            }
            if(row>0)
            {
                liveCount += current[row - 1,col];
                if(col<lastIndex)
                {
                    liveCount += current[row - 1,col + 1];
                }
            }
            if (col < lastIndex)
                liveCount += current[row,col + 1];
            if (col>0)
            {
                liveCount += current[row,col - 1];
                if (row < lastIndex)
                {
                    liveCount += current[row + 1,col-1];
                }
            }
            if(row<lastIndex)
            {
                liveCount += current[row + 1,col];
            }
            if(row<lastIndex&col<lastIndex)
            {
                liveCount += current[row + 1,col + 1];
            }
            return liveCount == 2 ? 1 : 0;
        }
    }
}
