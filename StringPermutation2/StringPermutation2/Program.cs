using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPermutation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "ABCD";
            // at some point s1+s1 = A[BCDA]BCD 
            string s2 = "CDBA";

            Console.WriteLine("Result is {0}",isRotation(s1,s2));
            Console.ReadKey();

        }

        static bool isRotation(string s1, string s2)
        {

            string temp = s1+""+s1;
            if (temp.Contains(s2))
                return true;

            return false;
        
        }

    }
}
