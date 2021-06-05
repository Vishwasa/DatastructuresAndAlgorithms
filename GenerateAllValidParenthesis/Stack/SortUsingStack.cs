using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    static class SortUsingStack
    {
        public static void sort()
        {
            var list = new List<int>() { 66, 96, 43, 28, 14, 1, 41, 76, 70, 81, 22, 11, 42, 78, 4, 88, 70, 43, 90, 6, 12 };
            var ans = solve(list);
            printArray(ans);
        }
        private static void printArray(List<int> M)
        {
            for (int m = 0; m < M.Count(); m++)
            { Console.Write(M[m] + ", "); }
            Console.WriteLine("End");
        }
        public static List<int> solve(List<int> A)
        {
            var stk = new Stack<int>();
            var additionalStack = new Stack<int>();
            foreach (var item in A)
            {
                if (stk.Count == 0 || stk.Peek() > item)
                {
                    stk.Push(item);
                }
                else if (stk.Peek() < item)
                {
                    while (stk.Count > 0 && stk.Peek() < item)
                    {
                        additionalStack.Push(stk.Pop());
                    }
                    stk.Push(item);
                    while (additionalStack.Count > 0)
                    {
                        stk.Push(additionalStack.Pop());
                    }
                }
            }
            return stk.ToList();
        }
    }
}
