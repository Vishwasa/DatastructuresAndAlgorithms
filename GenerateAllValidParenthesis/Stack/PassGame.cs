using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    static class PassGame
    {
        public static int solve(int A, int B, List<int> C)
        {
            List<int> stack = new List<int>();
            foreach (var item in C)
            {
                if (item == 0)
                {
                    stack.RemoveAt(stack.Count - 1);
                }
                else
                {
                    stack.Add(item);
                }
            }
            if (stack.Count==0)
            {
                return -1;
            }
            return stack[stack.Count - 1];
        }
        public static int solve1(int A, int B, List<int> C)
        {
            var stack = new Stack<int>();
            stack.Push(B);
            foreach (var item in C)
            {
                if (item == 0 && stack.Count > 0)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(item);
                }
            }
            if (stack.Count == 0)
            {
                return -1;
            }
            return stack.Peek();
        }
    }
}
