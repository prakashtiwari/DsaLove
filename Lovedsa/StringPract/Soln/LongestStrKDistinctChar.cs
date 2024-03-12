using System.Collections.Generic;
using System;


namespace StringPract.Soln
{
    public class LongestStrKDistinctChar
    {
        public int GetLongestStringKDistChar(string s, int k)
        {
            int l = 0;
            int maxCount = 0;
            int count = k;

            Dictionary<int, int> map = new Dictionary<int, int>(k);

            for (int i = 0; i < s.Length; i++)
            {

                if (map.ContainsKey(s[i]))
                {
                    map[s[i]]++;
                }
                else
                {
                    map.Add(s[i], 1);
                }
                while (map.Count > k)
                {
                    map[s[l]]--;
                    if (map[s[l]] == 0)
                    {
                        map.Remove(s[l]);
                    }
                    l++;
                }
                maxCount = Math.Max(maxCount, i - l + 1);
            }

            return maxCount;
        }
    }
}
