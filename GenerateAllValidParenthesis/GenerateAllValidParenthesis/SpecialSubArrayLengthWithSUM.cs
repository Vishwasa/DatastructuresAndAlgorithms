using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAllValidParenthesis
{
    internal static class SpecialSubArrayLengthWithSUM
    {
        public static int solve(List<int> A, int B)
        {
            var start = 0;
            var end = A.Count();
            while (start <= end)
            {
                var mid = (start + end) / 2;
                if (start == end)
                {
                    return start;
                }
                if (FesibilityCheck(A, mid, B))
                {
                    //you can avoid below block by keeping ans variable and copying ans and doing start=mid+1 all the time.
                    if (start == mid)
                    {
                        if (FesibilityCheck(A, mid + 1, B))
                        {
                            mid++;
                        }
                        else
                        {
                            return start;
                        }
                    }
                    start = mid;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return 0;
        }

        private static bool FesibilityCheck(List<int> A, int mid, int B)
        {
            long sum = GetSumForFirstWindow(A, mid);
            for (int i = mid; i < A.Count; i++)
            {
                if (sum > B)
                {
                    return false;
                }
                sum += A[i];
                sum -= A[i - mid];//5, 17, 100, 11 
            }
            if (sum > B)
            {
                return false;
            }
            return true;
        }

        private static long GetSumForFirstWindow(List<int> a, int mid)
        {
            long sum = 0;
            for (int i = 0; i < mid; i++)
            {
                sum += a[i];
            }
            return sum;
        }
    }
}
