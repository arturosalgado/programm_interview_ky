using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "Cinco";
            Console.WriteLine("first");
           
            string r = reverse(s);
            Console.WriteLine(r);
            Console.ReadKey();
        }

        static void swap(char []a, int i, int j){
        
                char t = a[i];
                a[i]= a[j];
                a[j]=t;

        }

        static void print(char[] a)
        {

            foreach (char x in a)
            {
                Console.Write("[{0:D2}] ", x);

            }
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("|{0:D2}| ", i);
            }
            Console.WriteLine();

        }
        static String reverse(String s)
        {
            char[] a = s.ToCharArray();
            int first=0; 
            int last = a.Length-1;
            while(first <= last)
            {
                print(a);
                swap(a,first,last);
                first++;
                last--;
               
                Console.ReadKey();
            }

            return new String(a);
        }
    }
}
