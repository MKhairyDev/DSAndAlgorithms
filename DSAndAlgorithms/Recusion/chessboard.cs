using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgorithms.Recusion
{
    public class Chessboard : IExecute
    {
        public bool Place8Queens(int[,]chessBoard,int col)
        {
            if(col>=chessBoard.GetLength(1))
            {
                return true;
            }
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                chessBoard[row, col] = 1;
                if(IsSafe(chessBoard, row,  col))
                {
                    if (Place8Queens(chessBoard, col + 1))
                        return true;
                }
                chessBoard[row, col] = 0;
            }
            return false;
           
        }
       private bool IsSafe(int[,] chessBoard, int row, int col)
        {
            if(!IsRowSafe(chessBoard,row))
            {
                return false;
            }
            if (!IsColSafe(chessBoard, col))
            {
                return false;
            }
            if (!IsLeftDiagonalSafe(chessBoard, row, col))
            {
                return false;
            }
            if (!IsRightDiagonalSafe(chessBoard, row, col))
            {
                return false;
            }
            return true;
        }
        private bool IsRowSafe(int[,] chessBoard, int row)
        {
            int rowSum=0;
            for (int colIndex = 0; colIndex < chessBoard.GetLength(1); colIndex++)
            {
                 rowSum += chessBoard[row, colIndex];
                if(rowSum>1)
                {
                    return false;
                }
            }
            return true;

        }
        private bool IsColSafe(int[,] chessBoard, int currentCol)
        {
            int colSum = 0;
            for (int rowIndex = 0; rowIndex < chessBoard.GetLength(0); rowIndex++)
            {
                colSum += chessBoard[rowIndex,currentCol];
                if (colSum > 1)
                {
                    return false;
                }
            }
            return true;

        }
    
        private bool IsLeftDiagonalSafe(int[,] chessBoard, int currentRow, int currentCol)
        {
        int r = 0;
        int c = 0;
        int sum = 0;
        if(r>c)
        {
            r = r - c;
        }
        else
        {
            c = c-r;
        }
        while (r< chessBoard.GetLength(0)&&c< chessBoard.GetLength(1))
        {
            sum += chessBoard[r++, c++];
            if (sum > 1)
                return false;
        }
        return true;

        }
    private bool IsRightDiagonalSafe(int[,] chessBoard, int row, int col)
    {
        int matrixLength = chessBoard.GetLength(0);
        int r = 0;
        int c = matrixLength - 1;
        int sum = 0;

        if (r + c < matrixLength)
        {
            c = Math.Min(row + col, matrixLength - 1);
        }
        else
        {
            r = (r + c) % (matrixLength - 1);
        }
        while (r < matrixLength && c >= 0)
        {
            sum += chessBoard[r++, c--];
            if (sum > 1)
                return false;
        }
        return true;
    }
        public void Run()
        {
            int[,] chessboard = new int[4,4];

                var res = Place8Queens(chessboard, 0);
            
        }
    }
}
