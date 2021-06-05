using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAllValidParenthesis
{
    static class MatrixSearch
    {
        static void MatrixSearching()
        {
            var A = new List<List<int>>()
            {
                new List<int>(){ 1, 3, 5 },
                new List<int>(){ 2, 6, 9},
                new List<int>(){ 3, 6, 9 }
            };
            var ans = searchMatrix(A, 6);
            Console.WriteLine(ans);
        }
        public static int searchMatrix(List<List<int>> A, int B)
        {
            foreach (var item in A)
            {
                var found = item.BinarySearch(B);
                if (found > 0)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
