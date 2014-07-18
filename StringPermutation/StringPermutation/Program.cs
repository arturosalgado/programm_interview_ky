using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPermutation
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1 = "abc";
            string s2 = "cab";

            Console.WriteLine("R {0}", isPermutation(s1,s2));
            Console.ReadKey();

        }

        static bool isPermutation(string a , string b)
        {
            if (a.Length != b.Length) return false; // no need to continue;

            a = sort(a);
            b = sort(b);
            if (a == b) return true;

            return false;
        }

        static string sort(String s)
        {
            char[] a = s.ToCharArray();
            Array.Sort(a);

            return new string(a);
        }
    }
}
