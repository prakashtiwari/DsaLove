using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolution.Solution
{
    public class SubArrayKDistinctNum
    {
        public int GetSubArrayCountKDistinctNum(int[] nums, int k)
        {
            return GetSubArrayKDistinctNum(nums, k)- GetSubArrayKDistinctNum(nums, k-1);
        }
        public int GetSubArrayKDistinctNum(int[] nums, int k)
        {
            int l = 0;
            // int count = 0;
            int subArrayCount = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    map[nums[i]]++;
                }
                else
                {
                    map.Add(nums[i], 1);
                }
                while (l < nums.Length && map.Count > k)
                {
                    Console.WriteLine("Item to shrink"+ nums[l] + " " + i + " " + map.Count + " K " + k+ "Left is"+ l);
                    map[nums[l]]--;
                    if (map[nums[l]] == 0)
                        map.Remove(nums[l]);
                    l++;
                }
                subArrayCount = subArrayCount + i - l + 1;

            }
            return subArrayCount;

        }
    }
}
