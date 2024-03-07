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


            SubStringCountContainingChar subStringCountContainingChar = new SubStringCountContainingChar();
            int subStrCount = subStringCountContainingChar.GetNumOfSubString("abcabc");
            Console.WriteLine($"Total substring count: {subStrCount}");
        }
    }
}
