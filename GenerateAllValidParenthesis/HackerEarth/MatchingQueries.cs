using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth
{
    class MatchingQueries
    {

        public static void MatchingString()
        {
            solve();
        }
        public static List<List<int>> solve()
        {
            var sentences = new List<string>(3) { "it go will away", "go do art", "what to will east" };
            //var Queries = new List<string>(2) { "jim tom", "likes" };
            var Queries = new List<string>(2) { "it will", "go east will", "will" };
            var output = new List<List<int>>();
            foreach (var q in Queries)
            {
                var IndividualMatchedList = new List<int>();
                for (int i = 0; i < sentences.Count(); i++)
                {
                    int MatchedCount = GetMatchedCount(sentences[i], q);
                    for (int k = 0; k < MatchedCount; k++)
                    {
                        IndividualMatchedList.Add(i);
                    }
                }
                if (IndividualMatchedList.Count == 0)
                {
                    IndividualMatchedList.Add(-1);
                }
                output.Add(IndividualMatchedList);
            }
            return output;
        }
        private static int GetMatchedCount(string sentence, string q)
        {
            var qStringArray = q.Split(' ');
            var minMatch = Int32.MaxValue;
            foreach (var qString in qStringArray)
            {
                int temp = GetMatchedCountForAQueryString(sentence, qString);
                minMatch = Math.Min(minMatch, temp);
                if (minMatch == 0)
                {
                    return 0;
                }
            }
            return minMatch;
        }

        private static int GetMatchedCountForAQueryString(string sentence, string qString)
        {
            var ans = 0;
            for (int i = 0; i <= sentence.Length - qString.Length; i++)
            {
                if (sentence.Substring(i, qString.Length).Equals(qString))
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}
