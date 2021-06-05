using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPointers
{
    static class ContainerWithMostWater
    {
        public static void Container()
        {
            var A = new List<int>() { 1, 5, 4, 3 };
            var ans = maxArea(A);
            Console.WriteLine(ans);
        }
        public static int maxArea(List<int> A)
        {
            var ans = 0;
            for (int i = 0, j=A.Count-1; i < j; )
            {
                var temp = Math.Min(A[i], A[j]) * (j - i);
                ans = (temp > ans) ? temp : ans;
                if (A[i]<A[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return ans;
        }
    }
}
