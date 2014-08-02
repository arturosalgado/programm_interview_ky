using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancePoint
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = { 10,-5,1,3,2};
            Console.WriteLine("balance naive is {0}",naive(a));
            Console.WriteLine("balance improved is {0}",improved(a));
            
            Console.ReadKey();
        }

        static int naive(int []a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int sumLeft  = 0;
                int sumRight = 0;
                for (int p = 0; p <= i; p++)
                {
                    sumLeft += a[p];
                }
                for (int q = i; q < a.Length; q++)
                { 
                    sumRight+= a[q];
                }
                if (sumRight == sumLeft) return i;
            }
            return -1; // no balance point;
        }

        static int improved(int[] a)
        { 
            int []left = new int [a.Length];
            int []right = new int[a.Length];

            left[0] = a[0];
            for (int t = 1; t < a.Length; t++)
            {
                left[t] = left[t - 1] + a[t];
            }
            right[a.Length - 1] = a[a.Length - 1];
            for (int u = a.Length - 2; u >= 0; u--)
            {
                right[u] =  right[u + 1]+a[u];
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (left[i] == right[i]) return i;
            }
            return -1;
        }

    }
}
