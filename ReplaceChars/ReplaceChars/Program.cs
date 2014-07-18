using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceChars
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "ab c";  // a%20b%20c%20 // ab c = ab%20c

            int size = s.Length + calc(countSpaces(s));

            
            Console.WriteLine("Size is {0}",size);
           
            Console.WriteLine("Final is {0}",append(s,size));

            Console.ReadKey();
            

        }

        static string append(string s, int size)
        {

            Console.WriteLine("received size {0}",size);
            char[] a = new char[size];

            char[] orig = s.ToCharArray();
            Console.WriteLine(orig);
            Console.ReadKey();
            int index = orig.Length-1;
            int i =  a.Length - 1;

            Console.WriteLine("i is {0}",i );
           
            while ( i >= 0)
            {
                if (orig[index] != ' ')
                {
                    a[i] = orig[index];
                    index--;
                    i--;
                }
                else {

                    a[i] = '%'; i--;
                    a[i] = '$'; i--;
                    a[i] = '*'; i--;
                    index--;

                }
              
                print(a);
            }

            return new String(a);
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
        static int countSpaces(string s)
        {   int count =0; 
            foreach(char c in s)
            {
                if (c == ' ') count++;
            }
            return count;
        }
        static int calc(int spaces )
        {
            return spaces * 2; 
        }
    }
}
