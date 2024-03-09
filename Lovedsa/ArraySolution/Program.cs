using ArraySolution.Solution;
using System;

namespace ArraySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // MaxLenSubstring maxLenSubstring = new MaxLenSubstring();
            //int result= maxLenSubstring.GetMaxLenSameCharSubstring("ABAABCBBAB", 2);
            // Console.WriteLine($"Result is {result}");


            //SubStringCountContainingChar subStringCountContainingChar = new SubStringCountContainingChar();
            //int subStrCount = subStringCountContainingChar.GetNumOfSubString("abcabc");
            //Console.WriteLine($"Total substring count: {subStrCount}");
            //ZeroReplacementOfKNum zeroReplacementOfKNum = new ZeroReplacementOfKNum();
            //int maxLen = zeroReplacementOfKNum.GetMaxLenByReplacement(new int[] { 1, 1, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1 }, 2);
            //Console.WriteLine($"Max len after replacement: {maxLen}");
            //MaxFruitInBasket maxFruitInBasket = new MaxFruitInBasket();
            //int maxFruitType = maxFruitInBasket.GetMaxCount(new int[] { 1, 1, 2, 3, 1,1,3 }, 2);
            //Console.WriteLine($"Different fruit type: {maxFruitType}");

            //MaxPointByCard max = new MaxPointByCard();
            //int maxSum = max.GetMaxPointByCard(new int[] { 1, 2, 3, 6, 5, 6 }, 3);
            //Console.WriteLine($"Sum is : {maxSum}");
            BinarySubarrayWithSum binarySubarrayWithSum = new BinarySubarrayWithSum();
            int subArrayCount = binarySubarrayWithSum.GetBinSubarrayCount(new int[] { 1, 0, 1, 0,1 }, 2);
            Console.WriteLine($"Total subarray count : {subArrayCount}");
        }
    }
}
