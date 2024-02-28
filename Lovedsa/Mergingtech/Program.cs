using System;

namespace Mergingtech
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MergeSort mergeSort = new MergeSort();
            int[] arr = new int[] { 5, 1, 2, 6,3,7 };
            mergeSort.SortArr(arr, arr.Length);

            Console.ReadLine();
        }
    }
}
