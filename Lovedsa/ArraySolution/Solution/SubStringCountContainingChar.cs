using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolution.Solution
{
    public class SubStringCountContainingChar
    {
        public int GetNumOfSubString(string s)
        {
            int[] arr = new int[3];
            int ans = 0;
            int start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                arr[s[i] - 'a']++;
                while (arr[0] >= 1 && arr[1] >= 1 && arr[2] >= 1)
                {
                    ans += s.Length - i;
                    arr[s[start]-'a']--;
                    start++;
                }
            }
            return ans;
        }
    }
}
