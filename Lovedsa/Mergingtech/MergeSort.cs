using System.Collections.Generic;

namespace Mergingtech
{
    public class MergeSort
    {
        public void SortArr(int[] arr, int n)
        {
            MergeSortArr(arr, 0, n - 1);
        }

        private void MergeSortArr(int[] arr, int low, int high)
        {
            if (low >= high) return; //Base case
            int mid = (low + high) / 2;
            MergeSortArr(arr, low, mid);
            MergeSortArr(arr, mid + 1, high);
            MergeArray(arr, low, mid, high);

        }
        private void MergeArray(int[] arr, int low, int mid, int high)
        {
            List<int> temp = new List<int>();
            int left = low;
            int right = mid + 1;
            while (left <= mid && right <= high)
            {

                if (arr[left] <= arr[right])
                {

                    temp.Add(arr[left]);
                    left++;
                }
                else
                {
                    temp.Add(arr[right]);
                    right++;
                }
            }
            while (left <= mid)
            {
                temp.Add(arr[left]);
                left++;
            }
            while (right <= high)
            {
                temp.Add(arr[right]);
                right++;
            }

            for (int i = low; i <= high; i++)
            {

                arr[i] = temp[i - low];
            }
        }
    }
}
