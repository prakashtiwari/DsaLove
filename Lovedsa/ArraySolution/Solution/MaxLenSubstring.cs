using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolution.Solution
{
    public class MaxLenSubstring
    {
        public int GetMaxLenSameCharSubstring(string s, int k)
        {
            int l = 0;
            int result = 0;
            Dictionary<char, int> count = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (count.ContainsKey(s[i]))
                {
                    count[s[i]] += 1;
                }
                else
                {
                    count.Add(s[i], 1);
                }
                while ((i - l + 1) - count.Max(p => p.Value) > k)
                {
                    count[s[l]] -= 1; //reduce the frequency
                    l += 1;
                }
                result = Math.Max(result, i - l + 1);

            }
            return result;
        }
    }
}
