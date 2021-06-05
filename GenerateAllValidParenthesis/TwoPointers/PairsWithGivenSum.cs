using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPointers
{
    static class PairsWithGivenSum
    {
        public static void PairsWithASum()
        {
            var A = new List<int>() { 1, 1, 1 };
            var ans = solve(A, 2);
            Console.WriteLine(ans);
        }
        public static int solve(List<int> A, int B)
        {
            var mod = 1000 * 1000 * 1000 + 7;
            long ans = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (var item in A)
            {
                if (map.ContainsKey(B-item))
                {
                    ans = ((ans + map[B - item])%mod);
                }
                if (!map.ContainsKey(item))
                {
                    map.Add(item, 1);
                }
                else
                {
                    map[item]++;
                }
            }
            return (int)(ans % mod);
        }
        public static int solve1(List<int> A, int B)
        {
            long ans = 0;
            var mod = 1000 * 1000 * 1000 + 7;
            for (int i = 0, j = A.Count - 1; i < j;)
            {
                var sum = A[i] + A[j];
                if (B > sum)
                {
                    i++;
                }
                else if (B < sum)
                {
                    j--;
                }
                else
                {
                    ans = ((ans + 1) % mod);
                    var countBegining = 0;
                    var countEnd = 0;
                    if (i < j && A[i] == A[i + 1])
                    {
                        ans = ans - 1;
                        countBegining = 1;
                        while (i < j && A[i] == A[i + 1])
                        {
                            i++;
                            countBegining++;
                        }
                        if (i == j)
                        {
                            var temp = ((countBegining * (countBegining - 1) / 2) % mod);
                            ans = ((ans + temp) % mod);
                        }
                        i++;
                    }
                    else if (i < j && A[j] == A[j - 1])
                    {
                        countEnd = 0;
                        while (A[j] == A[j - 1] && i <= j)
                        {
                            j--;
                            countEnd++;
                        }
                        if (i == j)
                        {
                            var temp = ((countEnd * (countEnd - 1) / 2) % mod);
                            ans = ((ans + temp) % mod);
                        }
                        else if (i < j)
                        {
                            ans = ((ans + (countBegining * countEnd) % mod) % mod);
                        }
                        j--;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (i == j || j >= A.Count || i < 0)
                {
                    break;
                }
            }
            return (int)(ans % mod);
        }
    }
}
