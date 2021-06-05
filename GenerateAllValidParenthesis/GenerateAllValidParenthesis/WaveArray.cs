using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAllValidParenthesis
{
    static class WaveArray
    {
        public static List<int> wave(List<int> A)
        {
            A.Sort();
            for (int i = 0; i < A.Count-1; i=i+2)
            {
                var temp = A[i];
                A[i] = A[i + 1];
                A[i + 1] = temp;
                //1 2 3 4 5 6
                //2 1 4 3 6 5
                //swap(A[i], A[i + 1]);
                //2 4 5 7 9
                //4 2 7 5 9
            }
            return A;
        }

    }
}
