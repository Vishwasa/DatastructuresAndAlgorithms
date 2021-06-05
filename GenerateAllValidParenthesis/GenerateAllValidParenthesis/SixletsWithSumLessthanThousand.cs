using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAllValidParenthesis
{
    static class SixletsWithSumLessthanThousand
    {
        public static void Sixlets()
        {
            var A = new List<int>() { 508, 503, 412, 895, 256, 89, 245, 567, 9, 123 };
            var x = solve(A, 1);
            Console.WriteLine(x);
        }

        public static int solve(List<int> A, int B)
        {
            int ans = 0;
            ans = RecursiveCall(A, B, 0, 0, 0);
            return ans;
        }

        public static int RecursiveCall(List<int> a, int b, int sum, int count, int index)
        {
            var ans = 0;
            if (sum > 1000)
            {
                return ans;
            }
            if (count == b && sum>0)
            {
                return ++ans;
            }
            if (index==a.Count)
            {
                return ans;
            }
            return RecursiveCall(a, b, sum + a[index], count+1, index + 1) + RecursiveCall(a, b, sum, count, index + 1);
        }
    }
}
