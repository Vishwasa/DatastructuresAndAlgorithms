using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAllValidParenthesis
{
    public static class MatrixMedian
    {
        public static void callMatrixMedian()
        {
            var A = new List<List<int>>()
            {
                new List<int>(){ 1, 3, 5 },
                new List<int>(){ 2, 6, 9},
                new List<int>(){ 3, 6, 9 }
            };
            //10,20,30,30,31,35,40,60,90
            var B = new List<List<int>>()
            {
                new List<int>(){1, 1, 4, 6, 6}
            };
            int ans = findMedian(B);
            Console.WriteLine(ans);
        }

        private static int findMedian(List<List<int>> A)
        {
            var cols = A[0].Count();
            var rows = A.Count();
            var desiredLocation = (rows * cols) / 2;
            int min = 0, max = 1000000000;
            var ans = -1;
            while (min <= max)
            {
                var mid = min + ((max - min) >> 1);
                if (GetCountGreaterThanMid(A, mid) > desiredLocation)
                {
                    max = mid - 1;
                    if (max<min)
                    {
                        ans = max;
                    }
                }
                else
                {
                    ans = min;
                    min = mid + 1;
                }
            }
            return ans;
        }

        private static int GetCountGreaterThanMid(List<List<int>> a, int mid)
        {
            var count = 0;
            foreach (var item in a)
            {
                var getPosition = Array.BinarySearch(item.ToArray(), mid);
                if (getPosition < 0)
                {
                    getPosition = Math.Abs(getPosition) - 1;
                }
                count += getPosition;
            }
            return count;
        }

        public static int findMedianDidntWork(List<List<int>> A)
        {
            var cols = A[0].Count();
            var rows = A.Count();
            var min = A[0][0];
            var max = A[0][cols - 1];
            findMinAndMax(A, ref min, ref max, cols, rows);
            var desiredLocation = (rows * cols) / 2;
            var possibleAns = 0;
            while (min <= max)
            {
                var mid = (min + max) / 2;
                int count = 0;
                FeasibilityCheck(A, desiredLocation, mid, ref count, ref possibleAns);
                if (count == desiredLocation)// || count == desiredLocation + 1 || count + 1 == desiredLocation)
                {
                    return possibleAns;
                }
                else if (count > desiredLocation)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return possibleAns;
        }

        private static void FeasibilityCheck(List<List<int>> a, int desiredLocation, int mid, ref int count, ref int possibleAns)
        {
            foreach (var item in a)
            {
                var getPosition = Array.BinarySearch(item.ToArray(), mid);
                if (getPosition < 0)
                {
                    getPosition = Math.Abs(getPosition) - 1;
                }
                if (getPosition < item.Count)
                {
                    possibleAns = item[getPosition];
                }
                count += getPosition;
                if (count > desiredLocation)
                {
                    return;
                }
            }
        }

        private static void findMinAndMax(List<List<int>> a, ref int min, ref int max, int cols, int rows)
        {
            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i][0] < min)
                {
                    min = a[i][0];
                }
                if (a[i][cols - 1] > max)
                {
                    max = a[i][cols - 1];
                }
            }
        }
    }
}
