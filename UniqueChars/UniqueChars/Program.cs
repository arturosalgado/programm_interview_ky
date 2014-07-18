using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars
{
    class Program
    {
        static void Main(string[] args)
        {

          

            string str2 = "case";
            Console.WriteLine("test string is ({0}) result test is {1} ", str2, unique1(str2));
            Console.WriteLine("test string is ({0}) result test is {1} ", str2, unique2(str2));
            Console.WriteLine("test string is ({0}) result test is {1} ", str2, unique3(str2));

            Console.ReadKey();


        }

        //use a list to keep track of what you have seen so far 
        static bool unique1(String s)
        {
            List<char> list = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (list.Contains(s[i]))
                    return false;
                else {
                    list.Add(s[i]);
                }
            }
            
            
            return true;
        }


        static bool unique2(String s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {

                    //Console.WriteLine("index of i {0}",s[i]);
                    //Console.WriteLine("index of j {0}", s[j]);
                    if (s[j] == s[i] &&  i!= j) return false;
                        
                }
            
            }


            return true;
        }

        static bool unique3(String s)
        {
            char []a = s.ToCharArray();

            Array.Sort(a);

            Console.WriteLine("sorted {0}",new String(a));

            int m; 
            int i;
            for ( i = 0, m = 1; i < a.Length; ++i,m++)
            {
                Console.WriteLine("{0}{1}",a[i],a[m]);
                if (a[i] == a[m] ) return false;
            }
                return true;
        }

    }
}
