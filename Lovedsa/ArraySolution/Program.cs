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
            ZeroReplacementOfKNum zeroReplacementOfKNum = new ZeroReplacementOfKNum();
            int maxLen = zeroReplacementOfKNum.GetMaxLenByReplacement(new int[] { 1, 1, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1 }, 2);
            Console.WriteLine($"Max len after replacement: {maxLen}");
        }
    }
}
