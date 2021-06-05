using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    static class MaximumFrequencyStack
    {
        public static void frequencyOfAstack()
        {
            var list = new List<List<int>>(){
          new List<int>(){1, 2},
          new List<int>(){2, 0},
          new List<int>(){1, 2},
          new List<int>(){1, 7},
          new List<int>(){2, 0},
          new List<int>(){2, 0},
          new List<int>(){1, 4},
          new List<int>(){1, 1},
          new List<int>(){1, 7}
        };
            var ans = MaximumFrequencyStack.solve(list);
            printArray(ans);
        }
        private static void printArray(List<int> M)
        {
            for (int m = 0; m < M.Count(); m++)
            { Console.Write(M[m] + ", "); }
            Console.WriteLine("End");
        }

        public static List<int> solve(List<List<int>> A)
        {
            var dict = new Dictionary<int, int>();
            var stack = new Stack<int>();
            var maxFreqStack = new Stack<int>();
            var output = new List<int>();
            foreach (var item in A)
            {
                if (item[0] == 1)
                {
                    stack.Push(item[1]);
                    if (dict.ContainsKey(item[1]))
                    {
                        dict[item[1]]++;
                        if (maxFreqStack.Count == 0)
                        {
                            maxFreqStack.Push(item[1]);
                        }
                        else if (dict[item[1]] >= dict[maxFreqStack.Peek()])
                        {
                            maxFreqStack.Push(item[1]);
                        }
                        else
                        {
                            maxFreqStack.Push(maxFreqStack.Peek());
                        }
                    }
                    else
                    {
                        dict.Add(item[1], 1);
                        if (maxFreqStack.Count == 0)
                        {
                            maxFreqStack.Push(item[1]);
                        }
                        else if (dict[item[1]] >= dict[maxFreqStack.Peek()])
                        {
                            maxFreqStack.Push(item[1]);
                        }
                        else
                        {
                            maxFreqStack.Push(maxFreqStack.Peek());
                        }
                    }
                    output.Add(-1);
                }
                else
                {
                    var x = stack.Pop();
                    if (dict.ContainsKey(x))
                    {
                        dict[x]--;
                    }
                    if (maxFreqStack.Count != 0)

                        if (maxFreqStack.Count != 0)
                        {
                            output.Add(maxFreqStack.Pop());
                            //output.Add(maxFreqStack.Peek());
                        }
                        else
                        {
                            output.Add(-1);
                        }
                }

            }
            return output;
        }
    }
}
