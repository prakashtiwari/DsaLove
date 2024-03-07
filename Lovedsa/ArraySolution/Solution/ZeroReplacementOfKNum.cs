using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolution.Solution
{
    public class ZeroReplacementOfKNum
    {
        public int GetMaxLenByReplacement(int[] nums, int k)
        {
            int s = 0;
            int z = 0;
            int maxLen = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    z++;
                while (z > k)
                {
                    if (nums[s] == 0) //If left window is shrinking and encountering zero, means add one zero
                        z--;
                    s++;
                }
                maxLen = Math.Max(maxLen, i - s + 1);
            }
            return maxLen;

        }
    }
}
