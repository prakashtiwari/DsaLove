using System;

namespace StringPract.Soln
{
    public class MinWindowSubsequence
    {
        public string GetMinWindowSubsequence(string s, string t)
        {
            string minWindow = string.Empty;
            int i = 0;
            int j = 0;
            int min = s.Length + 1;
            int startIndex = -1;
            //int end = 0;
            while (i < s.Length)
            {
                //i ++;
                if (s[i++] == t[j])
                {
                    j++;
                    if (j == t.Length)
                    {
                        int tail = i - 1;
                        int head = tail;
                        int jj = t.Length - 1;
                        while (jj >= 0)
                        {
                            if (t[jj] == s[head])
                            {
                                jj--;
                            }
                            head--;
                        }
                        Console.WriteLine($" head {head}");
                        head = head + 1;
                        int currLen = tail - head + 1;
                        if (currLen < min)
                        {
                            min = currLen;
                            startIndex = head;

                        }
                        j = 0;
                        i = head + 1;
                        Console.WriteLine($" i is {i}");

                    }
                   
                }
               
               
            }
            return startIndex == -1 ? "" : s.Substring(startIndex, min);
        }
    }
}
