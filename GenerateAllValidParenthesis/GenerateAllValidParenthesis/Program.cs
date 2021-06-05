using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAllValidParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            //MatrixMedian.callMatrixMedian();
            //SixletsWithSumLessthanThousand.Sixlets();
            //PairSumDivisibleByM.CountNumberOfPairs();
            ReverseASentence.Reverse();

            //var list = new List<string>() {"53..7....", "6..195...", ".98....6.", "8...6...3", "4..8.3..1", "7...2...6", ".6....28.", "...419..5", "....8..79"};
            //var ans = ValidSudoku.isValidSudoku(list);
            //var list = new List<int>() { 3,2,1};
            var list = new List<int>() { 28, 18, 44, 49, 41, 14 };
            //var ans = InversionPairOfArrays.solve(list);
            //var ans = DpToGrayCode.solve(3);

            var list1 = new List<int>() { 1, 2, 4, 5 };
            //var list1 = new List<int>() { 1, 3, 2, 4, 5 };
            //var list1 = new List<int>() { 1, 1, 10, 10, 15, 10, 15, 10, 10, 15, 10, 15 };
            //var list1 = new List<int>() { 1, 1, 2, 3, 3, 4, 8, 9, 11, 9, 11, 12, 12, 11, 9, 14, 19, 20, 20 };
            //var ans = UnsortedSubArray.subUnsort(list1);

            //var list1 = new List<int>() { 1, 2, 3, 4, 5 };
            //var B = 10;
            //var ans = SpecialSubArrayLengthWithSUM.solve(list1, B);
            //Console.WriteLine(ans);
            /*var list = generateParenthesis(3);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }*/

            //----------------Allocate Books Problem
            //var list2 = new List<int>() { 12, 34, 67, 90};
            //var list2 = new List<int>() { 12};
            //var list2 = new List<int>() { 5, 82, 52, 66, 16, 37, 38, 44, 1, 97, 71, 28, 37, 58, 77, 97, 94, 4, 9 };
            //var list2 = new List<int>() { 73, 58, 30, 72, 44, 78, 23, 9 };
            //var list2 = new List<int>() { 91, 20, 62, 33, 97, 31, 88, 89, 73, 77, 4, 58, 0, 54, 60, 15, 47, 80, 30, 55, 46, 7, 38, 0, 26, 35, 57, 13 };
            //var list2 = new List<int>() { 3, 32, 32, 41, 54, 77, 17 };
            //var list2 = new List<int>() { 67, 21, 95, 12, 71, 1, 90, 31, 38, 57, 16, 90, 40, 79, 35, 6, 72, 98, 95, 19, 54, 23, 89 };
            //var ans = AllocateBooks.books(list2, 24);
            //var ans = AllocateBooks.books(list2, 2);
            //var ans = AllocateBooks.books(list2, 2);
            //Console.WriteLine(ans);
            //-----------------
            Console.ReadKey();
        }


        public static List<string> generateParenthesis(int A)
        {
            if (A == 0)
            {
                return new List<string>();
            }
            else
            {
                return AddOneMorePair(A - 1, new List<string>() { "()" });
            }
        }
        internal static List<string> AddOneMorePair(int A, List<string> list)
        {
            var ans = new List<string>();
            var set = new HashSet<string>();
            var pairString = "()";
            if (A == 0)
            {
                return list;
            }
            else
            {
                foreach (string str in list)
                {
                    var strBuilder = new StringBuilder();
                    for (int i = 0; i < str.Length; i++)
                    {
                        strBuilder.Append(str);
                        strBuilder.Insert(i, pairString);
                        var temp = strBuilder.ToString();
                        if (!set.Contains(temp))
                        {
                            set.Add(temp);
                        }
                        strBuilder.Clear();
                    }
                }
                ans = set.ToList();
            }
            return AddOneMorePair(A - 1, ans);
        }
    }
}
