using System.Linq;

namespace StringPract.Soln
{
    public class MinLenSubstring
    {
        public string GetMinLenStringContainingChar(string s, string t)
        {
            int[] map = new int[128];
            int start = 0;
            int end = 0;
            int minLen = int.MaxValue;
            int startIndex = 0;
            char[] source = s.ToArray();
            int sLen = 0;
            int count = t.Length;
            for (int i = 0; i < t.Length; i++)
            {
                map[t[i]]++;
            }

            while (end < source.Length)
            {
                if (map[source[end]] > 0)
                {
                    count--;
                }
                map[source[end]]--;
                end++;
                while (count == 0)
                {
                    if (end - start < minLen)
                    {

                        startIndex = start;
                        minLen = end - start;
                    }                   
                    if (map[source[start]] == 0)
                    {
                        count++;
                    }
                    map[source[start]]++;
                    start++;
                }
            }
            return minLen == int.MaxValue ? "" : s.Substring(startIndex, minLen);
        }
    }
}
