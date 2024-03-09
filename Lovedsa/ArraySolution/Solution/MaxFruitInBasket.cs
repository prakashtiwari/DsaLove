using System;
using System.Collections.Generic;

namespace ArraySolution.Solution
{
    public class MaxFruitInBasket
    {
        public int GetMaxCount(int[] arr, int t)
        {

            int s = 0;
            int typeCount = 0;
            int maxType = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    map[arr[i]]++;
                }
                else
                {
                    map.Add(arr[i], 1);
                }
                while (map.Count > t)
                {
                    map[arr[s]]--;
                    if (map[arr[s]] == 0)
                    {
                        map.Remove(arr[s]);

                    }
                    s++;
                }
                maxType = Math.Max(maxType, i - s + 1);

            }
            return maxType;

        }
    }
}
