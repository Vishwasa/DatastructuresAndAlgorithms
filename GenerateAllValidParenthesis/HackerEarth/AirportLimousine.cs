using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth
{
    class AirportLimousine
    {
        public static void solve()
        {
            var listOfList = new List<List<int>>()
            {
                new List<int>(){0,1,-1 },
                new List<int>(){ 1, 0, -1 },
                new List<int>(){ 1, 1, 1 }
            };
            var ans = collectMax(listOfList);
            Console.WriteLine(ans);
        }
        public static int collectMax(List<List<int>> mat)
        {
            var TotalRows = mat.Count();
            var TotalCols = mat.Count();
            var personsCollected = 0;
            int ans = 0;
            personsCollected = RecursiveCallForAllAvailablePathsFromACell(mat, 0, 0, TotalRows, TotalCols, ans);
            if (mat[TotalRows - 1][TotalCols - 1] != 2)
            {
                return -1;
            }
            return personsCollected;
        }

        private static int RecursiveCallForAllAvailablePathsFromACell(List<List<int>> mat, int currentPositionRow, int currentPositionCol, int totalRows, int totalCols, int ans)
        {
            var StoreValueToRevert = 0;
            if (currentPositionRow >= totalRows || currentPositionCol >= totalCols ||
                currentPositionRow < 0 || currentPositionCol < 0 ||
                mat[currentPositionRow][currentPositionCol] == -1)
            {
                return 0;
            }
            if (mat[currentPositionRow][currentPositionCol] == 2)// && currentPositionRow == 0 && currentPositionCol == 0)
            {
                return ans;
            }
            else
            {
                ans = ans + mat[currentPositionRow][currentPositionCol];
                StoreValueToRevert = mat[currentPositionRow][currentPositionCol];
                mat[currentPositionRow][currentPositionCol] = 2;
            }
            var tempList = new List<int>(){RecursiveCallForAllAvailablePathsFromACell(mat, currentPositionRow, currentPositionCol + 1, totalRows, totalCols, ans),
                RecursiveCallForAllAvailablePathsFromACell(mat, currentPositionRow, currentPositionCol-1, totalRows, totalCols, ans),
                RecursiveCallForAllAvailablePathsFromACell(mat, currentPositionRow - 1, currentPositionCol, totalRows, totalCols, ans),
                RecursiveCallForAllAvailablePathsFromACell(mat, currentPositionRow + 1, currentPositionCol + 1, totalRows, totalCols, ans)
                };
            //mat[currentPositionRow][currentPositionCol] = StoreValueToRevert;
            return tempList.Max();
        }
    }
}
