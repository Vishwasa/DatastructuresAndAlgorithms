using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPointers
{
    static class SubarrayWithGivenSum
    {
        public static void SubArraySum()
        {
            var A = new List<int>() { 1, 2, 3, 4, 5 };
            //var A = new List<int>() { 5, 10, 20, 100, 105 };

            var x = solve(A, 15);
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
        }
        static List<int> solve(List<int> A, int sum)
        {
            var count = A.Count();
            var prefixsumArray = new long[count];
            prefixsumArray[0] = A[0];
            for (int i = 1; i < A.Count; i++)
            {
                prefixsumArray[i] = prefixsumArray[i - 1] + A[i];
            }
            var ans = FindIndexUsingPrefixSumArray(prefixsumArray.ToList(), sum);
            var output = new List<int>();
            if (ans.Count() == 1)
            {
                if (ans[0] == -1)
                {
                    return ans;
                }
                else
                {
                    return new List<int>() { A[ans[0]] };
                }
            }
            for (int i = ans[0]; i <= ans[1]; i++)
            {
                output.Add(A[i]);
            }
            return output;
        }
        static List<int> FindIndexUsingPrefixSumArray(List<long> prefixsumArray, int sum)
        {
            var count = prefixsumArray.Count();
            for (int i = -1, j = 0; (i <= j && j < count);)
            {
                long ivalue = 0;
                if (i >= 0)
                {
                    ivalue = prefixsumArray[i];
                }
                var comparableSum = prefixsumArray[j] - ivalue;
                if (i == j && prefixsumArray[j] == sum)
                {
                    return new List<int>() { i };
                }
                if (sum == comparableSum)
                {
                    if (i == -1)
                    {
                        return new List<int>() { 0, j };
                    }
                    return new List<int>() { i + 1, j };
                }
                else if (sum > comparableSum)
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }
            return new List<int>() { -1 };

        }
    }
}
