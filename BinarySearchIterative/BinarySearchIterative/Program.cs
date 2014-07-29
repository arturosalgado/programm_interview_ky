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

         
           Console.WriteLine("{0}", binarySearchR(a, 1, 0, 5));
           Console.WriteLine("{0}", binarySearchR(a, 4, 0, 5));
           Console.WriteLine("{0}", binarySearchR(a, 10, 0, 5));
           Console.WriteLine("{0}", binarySearchR(a, 15, 0, 5));
           Console.WriteLine("{0}", binarySearchR(a, 20, 0, 5));
           Console.WriteLine("{0}", binarySearchR(a, 30, 0, 4));

            

            Console.ReadKey();
        }

        static int binarySearchR(int[] a, int k, int low, int high )
        {
            if (high < low) {
                return -1;
            }
            int mid = low + (high - low) / 2;
            if (a[mid] > k)
            {
               return binarySearchR(a,k,low,mid-1);
            }
            else if (a[mid] < k)
            {
                return binarySearchR(a, k, mid + 1, high);
            }
            else {
                return mid;
            }
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
