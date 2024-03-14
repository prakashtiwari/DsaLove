using StringPract.Soln;
using System;

namespace StringPract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //MinLenSubstring minLen = new MinLenSubstring();

            //string res = minLen.GetMinLenStringContainingChar("ADOBECODEBANC", "ABC");
            MinWindowSubsequence minWindow = new MinWindowSubsequence();
           string s= minWindow.GetMinWindowSubsequence("abccdebdde", "bde");
        }
    }
}
