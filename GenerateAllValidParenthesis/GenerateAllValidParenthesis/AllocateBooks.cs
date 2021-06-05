using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAllValidParenthesis
{
    static class AllocateBooks
    {
        public static int ans = 0;
        public static int books(List<int> A, int B)
        {
            int totalnumberofPages = totalPages(A);
            int ans = FindMinimisedMaxPageForAStudent(A, totalnumberofPages, B);
            return ans;
        }

        private static int FindMinimisedMaxPageForAStudent(List<int> a, int totalnumberofPages, int b)
        {
            int start = 0;
            int end = totalnumberofPages;
            while (start<=end)
            {
                bool MoveToEnd = false;
                if (start == end)
                {
                    FesibleCheckFunction(a, start, b, ref MoveToEnd);
                    return ans;
                }
                int mid = (start+end)/ 2;
                if (FesibleCheckFunction(a, mid, b, ref MoveToEnd))
                {
                    end = mid-1;
                }
                else if (MoveToEnd)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return ans;
        }

        private static bool FesibleCheckFunction(List<int> a, int mid, int b, ref bool MoveToEnd)
        {
            var countThePages = 0;
            var countStudents = 0;
            var maxPagesForAstudent = 0;
            for (int i = 0; i < a.Count; i++)
            {
                countThePages += a[i];
                if (countThePages > mid)
                {
                    if ((countThePages - a[i]) > maxPagesForAstudent)
                        maxPagesForAstudent = (countThePages - a[i]);
                    countThePages = a[i];
                    countStudents++;
                }
                if ((b - countStudents) == (a.Count-i))
                {
                    if (countThePages > maxPagesForAstudent)
                        maxPagesForAstudent = countThePages;
                    while (i<a.Count)
                    {
                        if (a[i] > maxPagesForAstudent)
                            maxPagesForAstudent = a[i];
                        i++;
                    }
                    countThePages = 0;
                    countStudents = b;
                    break;
                }
            }
            if ((countThePages) > 0)
            {
                if (countThePages>maxPagesForAstudent)
                {
                    maxPagesForAstudent = countThePages;
                }
                countStudents++;
            }
            MoveToEnd = countStudents > b ? true : false;

            if (countStudents != b)
            {
                return false;
            }
            ans = maxPagesForAstudent;
            return true;

        }

        private static int totalPages(List<int> a)
        {
            int sum = 0;
            foreach (var item in a)
            {
                sum += item;
            }
            return sum;
        }
    }
}
