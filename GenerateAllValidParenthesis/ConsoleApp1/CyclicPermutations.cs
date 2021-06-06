using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class CyclicPermutations
    {
        public static void CheckTheCount()
        {
            var ans = solve("111", "111");
            Console.WriteLine(ans);
        }
        public static int solve(string A, string B)
        {
            var ans = 0;
            var charArray = string.Concat(A, A).ToCharArray();
            for (int i = 0; i < A.Length; i++)
            {
                string s = getsubstring(charArray, i, B.Length);
                if (s.Contains(B))
                {
                    ans++;
                }
                //ans += compareStrings(charArray, i, B.ToCharArray());
            }
            return ans;
        }

        private static string getsubstring(char[] charArray, int start, int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = start; i < (start + length); i++)
            {
                sb.Append(charArray[i]);
            }
            return sb.ToString();
        }

        private static int compareStrings(char[] charArray, int start, char[] v)
        {
            var count = 0;
            while (count < v.Count())
            {
                if (charArray[start] != v[count])
                {
                    return 0;
                }
                start++;
                count++;
                continue;
            }
            return 1;
        }
    }
}
