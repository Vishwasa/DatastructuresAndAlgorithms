using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAllValidParenthesis
{
    public static class UnsortedSubArray
    {
        public static List<int> subUnsort(List<int> A)
        {
            var PossibleLeft = 0;
            var PossibleRight = 0;
            var n = A.Count;
            var r = n - 1;
            var l = 0;
            int cmin = Int32.MaxValue, cmax = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] < cmax) r = i;
                else cmax = A[i];
            }
            for (int i = n - 1; i >= 0; i--)
            {
                if (A[i] > cmin) l = i;
                else cmin = A[i];
            }
            Console.WriteLine($"{l}= l:r ={r}");
            if (l == 0 && r == n - 1 && (A[0] < A[1]))
            {
                return new List<int>() { -1 };
            }
            return new List<int>() { l, r };
            //for (int i = 1; i < A.Count; i++)
            //{
            //    if (A[i] < A[i - 1])
            //    {
            //        PossibleLeft = i;
            //        min = A[i];
            //        while (i < A.Count)
            //        {
            //            if (min > A[i])
            //            {
            //                min = A[i];
            //            }
            //            i++;
            //        }
            //    }
            //}
            //for (int i = 0; i < PossibleLeft; i++)
            //{
            //    if (A[i] > min)
            //    {
            //        PossibleLeft = i - 1;
            //        break;
            //    }
            //}
            //for (int j = A.Count - 2; j >= PossibleLeft; j--)
            //{
            //    if (A[j] > A[j + 1])
            //    {
            //        PossibleRight = j+1;
            //        max = A[j];
            //        while (j > PossibleLeft)
            //        {
            //            if (max < A[j])
            //            {
            //                max = A[j];
            //            }
            //            j--;
            //        }
            //    }
            //}
            //var x = 0;
            //for (int i = PossibleRight; i < A.Count(); i++)
            //{
            //    if (A[i] > max && x>1)
            //    {
            //        PossibleRight = i-1;
            //        x++;
            //        break;
            //    }
            //}
            ////if (x > 1)
            ////{
            ////    PossibleRight++;
            ////}
            //if (A.Count == (PossibleRight - PossibleLeft + 1) ||  PossibleRight<=0)
            //{
            //    return new List<int>() { -1 };
            //}
            //if (PossibleLeft + 1 == PossibleRight - 1)
            //{
            //    PossibleRight++;
            //}
            //return new List<int>() { PossibleLeft+1, PossibleRight-1 };

        }
    }
}
