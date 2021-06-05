using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAllValidParenthesis
{
    public static class DpToGrayCode
    {
        public static List<int> solve(int A)
        {
            var output = new List<int>() { 0 };
            for (int i = 0; i < A; i++)
            {
                for (int j = output.Count - 1; j >= 0; j--)
                {
                    //Console.WriteLine(output[j]+1<<j);
                    output.Add((output[j] + (1 << i)));
                }
            }
            return output;
        }
    }
}
