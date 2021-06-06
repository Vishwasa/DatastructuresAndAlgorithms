using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    static class RemoveConsecutivePairs
    {
        public static void removeDuplicateChar()
        {
            var ans = solve("abbcdeef");
        }
        public static string solve(string S)
        {
            var stack = new Stack<char>();
            foreach (char ch in S)
            {
                if (stack.Count > 0 && stack.Peek() == ch)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(ch);
                }
            }
            var sb = new StringBuilder();
            var output = new StringBuilder();
            var count = stack.Count();
            for (var i = 0; i < count; i++)
            {
                sb.Append(stack.Pop());
            }
            for (int i = count-1; i >= 0; i--)
            {
                output.Append(sb[i]);
            }
            return output.ToString();
        }
    }
}
