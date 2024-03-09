namespace ArraySolution.Solution
{
    public class BinarySubarrayWithSum
    {
        private int GetBinSubarrayCountGoalK(int[] arr, int goal)
        {

            int s = 0;
            int count = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                while (s <= i && sum > goal)
                {
                    sum = sum - arr[s];
                    s++;
                }
                count += i - s + 1;

            }
            return count;
        }
        public int GetBinSubarrayCount(int[] arr, int goal)
        {
            int result = GetBinSubarrayCountGoalK(arr, goal) - GetBinSubarrayCountGoalK(arr, goal - 1);
            return result;


        }
    }
}
