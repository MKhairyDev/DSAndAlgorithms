using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.GeneralProblems
{
   public class SudokuBoard
    {
        public static bool IsValid(int[,]sudokBoard)
        {
            if(!IsValidRowsAndColumns(sudokBoard))
            {
                return false;
            }
            if(!IsValidBlocks(sudokBoard))
            {
                return false;
            }
            return true;
        }

        private static bool IsValidBlocks(int[,] sudokBoard)
        {
            Dictionary<int, HashSet<int>> rowSets = new Dictionary<int, HashSet<int>>();
            Dictionary<int, HashSet<int>> colSets = new Dictionary<int, HashSet<int>>();
            for (int i = 0; i < 9; i++)
            {
                rowSets.Add(i, new HashSet<int>());
                colSets.Add(i, new HashSet<int>());
            }
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    int cellValue=sudokBoard[row, col];
                    if (cellValue == -1)
                        continue;
                    if (cellValue < 1 || cellValue > 9)
                        return false;
                 bool isRowValueExist=  rowSets[row].Contains(cellValue);
                    if (!isRowValueExist)
                        return false;
                    bool isColValueExist = colSets[row].Contains(cellValue);
                    if (!isRowValueExist)
                        return false;
                    rowSets[row].Add(cellValue);
                    colSets[col].Add(cellValue);
                }

            }
            return true;
        }

        private static bool IsValidRowsAndColumns(int[,] sudokBoard)
        {
            Dictionary<int, HashSet<int>> blockList = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < 9; i++)
            {
                blockList.Add(i, new HashSet<int>());
            }
            for (int rowBlock = 0; rowBlock < 3; rowBlock++)
            {
                for (int colBlock = 0; colBlock < 3; colBlock++)
                {
                    for (int miniRow = 0; miniRow < 3; miniRow++)
                    {
                        for (int miniCol = 0; miniCol < 3; miniCol++)
                        {
                            int row=rowBlock * 3 + miniRow;
                            int col = colBlock + 3 + miniCol;
                           int cellValue=sudokBoard[row, col];
                            if (cellValue == -1)
                                continue;
                            if (cellValue < 1 || cellValue > 9)
                                return false;
                            int blockNumber = rowBlock * 3 + colBlock;
                          if (!  blockList[blockNumber].Contains(cellValue))
                            return false;
                            blockList[blockNumber].Add(cellValue);
                        }
                    }
                }
            }
            return true;
        }
    }
}
