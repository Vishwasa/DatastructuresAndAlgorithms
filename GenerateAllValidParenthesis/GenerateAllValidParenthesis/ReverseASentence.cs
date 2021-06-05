using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAllValidParenthesis
{
    static class ReverseASentence
    {
        public static void Reverse()
        {
            var ans = solve("x tb i f chfpzf");
            //var ans = solve("       fwbpudnbrozzifml osdt ulc jsx kxorifrhubk ouhsuhf sswz qfho dqmy sn myq igjgip iwfcqq                 ");
            Console.WriteLine(ans);
        }
        public static string solve(string A)
        {
            char[] B = A.Trim().ToCharArray();
            int start = 0, end = B.Length - 1;
            ReverseString(B, start, end);
            Console.WriteLine(new string(B));
            for (int i = 1; i < B.Length; i++)
            {
                if (B[i] != ' ' && B[i - 1] == ' ')
                {
                    start = i;
                }
                if ((B[i] == ' ' && B[i - 1] != ' ') || i == (B.Length - 1))
                {
                    int End = (i == (B.Length - 1)) ? i : (i - 1);
                    ReverseString(B, start, End);
                }

            }
            var output = new string(B);
            var array = output.Split(' ').ToList();
            var stringOutput = String.Join(" ", array.Where(s => !String.IsNullOrEmpty(s)).ToArray());
            return stringOutput;
        }

        private static void ReverseString(char[] a, int start, int end)
        {
            var mid = (start + end) / 2;
            while (start <= mid)
            {
                var temp = a[start];
                a[start] = a[end];
                a[end] = temp;
                start++;
                end--;
            }
        }
    }
}
