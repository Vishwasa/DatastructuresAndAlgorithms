using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAllValidParenthesis
{
    static class NQueensPlacement
    {
        static void placeQueen()
        {
            var ans = solveNQueens(4);
        }
        static void print(List<List<int>> ans)
        {
            foreach (var item in ans)
            {
                printArray(item);
            }
            Console.WriteLine("End");
        }
        private static void printArray(List<int> M)
        {
            for (int m = 0; m < M.Count(); m++)
            { Console.Write(M[m] + ", "); }
            Console.WriteLine();
        }
        public static List<List<string>> solveNQueens(int A)
        {
            //int[,] _board = new int[A, A];
            var _board = new List<List<string>>();
            for (int i = 0; i < A; i++)
            {
                _board.Add(new List<string>(A));
            }
            var nthBoard = new List<string>();
            placeQueenInBoard(0, A, ref _board, ref nthBoard);
            return _board;
        }

        private static void placeQueenInBoard(int rowNumber, int N, ref List<List<string>> board, ref List<string> nRowthBoard)
        {
            for (int col = 0; col < N; col++)
            {
                var currentRow = new List<string>();
                //if (positionIsSafe(rowNumber, col, N,currentRow))
                //{
                //    placeQueenInBoard(rowNumber + 1, N, ref board);
                //}
            }
        }

        private static bool positionIsSafe(int rowNumber, int i, int sizeOfBoard)
        {
            throw new NotImplementedException();
        }
    }
}
