using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAllValidParenthesis
{
    public static class ValidSudoku
    {
        public static int isValidSudoku(List<string> A)
        {
            var boxSet = new List<HashSet<char>>(9);
            var ColumnSet = new List<HashSet<char>>(9);
            var RowSet = new List<HashSet<char>>(9);
            for(int i=0; i<9; i++)
            {
                boxSet.Add(new HashSet<char>());
                ColumnSet.Add(new HashSet<char>());
                RowSet.Add(new HashSet<char>());
            }
            for (var s=0; s<A.Count(); s++)
            {
                var chArray = A[s].ToCharArray();
                for (var i=0; i<chArray.Length; i++)
                {
                    if (chArray[i] == '.')
                        continue;
                    else
                    {
                        if (!RowSet[s].Contains(chArray[i]))
                        {
                            RowSet[s].Add(chArray[i]);
                        }
                        else
                        {
                            return 0;
                        }
                        if (!ColumnSet[i].Contains(chArray[i]))
                        {
                            ColumnSet[i].Add(chArray[i]);
                        }
                        else
                        {
                            return 0;
                        }
                        if (!boxSet[3*(s / 3) + i / 3].Contains(chArray[i]))
                        {
                            boxSet[3*(s / 3) + i / 3].Add(chArray[i]);
                        }
                        else
                        {
                            return 0;
                        }
                        //boxSet[s%3+i%3]=
                    }
                }
            }
            return 1;
        }

    }
}
