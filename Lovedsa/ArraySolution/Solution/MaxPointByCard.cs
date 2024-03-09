using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolution.Solution
{
    public class MaxPointByCard
    {
        public int GetMaxPointByCard(int[] arr, int k)
        {
            int max = 0;
            int sum = 0;
            int n = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            //Vimp
            max = sum;

            for (int i = 0; i < k; i++)
            {
                sum = sum + arr[n - 1 - i] - arr[k - 1 - i];
                max = Math.Max(max, sum);
            }
            return max;
        }
    }
}
