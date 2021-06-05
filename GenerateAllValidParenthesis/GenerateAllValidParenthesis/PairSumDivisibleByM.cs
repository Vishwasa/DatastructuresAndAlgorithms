using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAllValidParenthesis
{
    public static class PairSumDivisibleByM
    {
        public static int CountNumberOfPairs()
        {
            //var A = new List<int>() { 84, 3, 9, 46, 79, 56, 24, 10, 26, 9, 93, 31, 93, 75, 7, 4, 80, 19, 67, 49, 84, 62, 100, 17, 40, 35, 84, 14, 81, 99, 31, 100, 66, 70, 2, 11, 84, 60, 89, 13, 57, 47, 60, 59, 60, 42, 67, 89, 29, 85, 83, 42, 47, 66, 80, 88, 85, 83, 82, 16, 23, 21, 55, 26, 2, 21, 92, 85, 26, 46, 3, 7, 95, 50, 22, 84, 52, 57, 44, 4, 23, 25, 55, 41, 49, };
            var A = new List<int>() { 1, 2, 3, 4, 5 };
            //var A = new List<int>() { 5, 17, 100, 11 };
            var B = 2;
            var ans = solve(A, B);
            Console.WriteLine(ans);
            return ans;

        }
        static int solve(List<int> A, int B)
        {
            var dict = new Dictionary<int, int>();
            int mod = 1000000007;
            long result = 0;
            long zeroCount = 0;
            foreach (int number in A)
            {
                var temp = number % B;
                var checkFor = B - temp;
                if (temp == 0 || temp == B)
                {
                    zeroCount++;
                    continue;
                }
                if (dict.ContainsKey(checkFor))
                {
                    result = (result + dict[checkFor]);
                    //dict[checkFor]++;
                }
                if (!dict.ContainsKey(temp))
                {
                    dict.Add(temp, 1);
                }
                else
                {
                    dict[temp]++;
                }
            }
            var tempZeroAns = ((zeroCount % mod * (zeroCount - 1) % mod) % mod) / 2;
            result = ((result + tempZeroAns) % mod);
            return (int)(result % mod);
        }
        public static int solve1(List<int> A, int B)
        {
            var dict = new Dictionary<int, int>();
            var mod = 1000000007;
            long result = 0;
            long zerosCount = 0;
            foreach (var number in A)
            {
                var temp = number % B;
                var checkingFor = B - temp;
                if (temp == 0)
                {
                    zerosCount++;
                    continue;
                }
                if (dict.ContainsKey(checkingFor))
                {
                    result = result + dict[checkingFor];
                    dict[checkingFor]++;
                }
                else
                {
                    dict.Add(temp, 1);
                }
            }
            var ans1 = (((zerosCount % mod) * (zerosCount - 1) % mod) % mod) / 2;
            result = ((result + ans1) % mod);
            return (int)(result % mod);
        }
    }
}
