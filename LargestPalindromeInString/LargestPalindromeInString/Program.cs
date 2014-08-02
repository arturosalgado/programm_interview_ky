using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string p = "pabccbaq";
            Console.WriteLine(isPalindrome(p.ToCharArray(),0,p.Length-1));
            Console.WriteLine(naive(p));
            Console.ReadKey();
        }
        static string naive(string s)
        {
            char[] a = s.ToCharArray();
            int longestStart = 0;
            int longestEnd = 0;

            for (int start = 0; start < s.Length; start++)
            {
                for (int end = start + 1; end <= s.Length; end++)
                {
                    if (isPalindrome(a, start, end - 1))
                    {
                        if (end - start > longestEnd - longestStart)
                        { longestEnd = end; longestStart = start; }
                    }
                }
            }
            return new string(a,longestStart,longestEnd-longestStart);

        }
        static bool isPalindrome(char []a, int start, int end)
        {
            for (int i = start; i <= (start + end) / 2; i++)
            {
                if (a[i] == a[start + end - i])
                    continue;
                else
                    return false;

            }

            return true;
        }

    }
}
