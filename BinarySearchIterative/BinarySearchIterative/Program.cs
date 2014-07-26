using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchIterative
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1,4,10,15,20 };
            Console.WriteLine("found {0}, send {1}", binarySearch(a, 10),10);
            Console.WriteLine("found {0}, send {1}", binarySearch(a, 15),15);
            Console.WriteLine("found {0}, send {1}", binarySearch(a, 1),1);
            Console.WriteLine("found {0}, send {1}", binarySearch(a, 5),5);

            

            Console.ReadKey();
        }
        static int binarySearch(int[] a, int k)
        {

            int l = 0;
            int u = a.Length - 1;
            int m;
            while (l <= u)
            {
                m = l+(u-l)/2;
                Console.WriteLine("m={0} l={1} u-l = {2}  l+(u-l)={3} / 2 = {4}", m, l, u - l, l + (u - l), l + (u - l)/2);
                Console.ReadKey();
                if (a[m] < k)
                {
                    l = m + 1;
                }
                else if (a[m] == k)
                {
                    return m;
                }
                else {
                    u = m - 1;
                }
            }

            return -1;
        
        }
    }
}
