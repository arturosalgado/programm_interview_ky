using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KadanesAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -3,-1,5,-4,-6,-1,-1};
            Console.WriteLine(kadanes(a));
            Console.ReadKey();
        }

        static int kadanes(int[] a)
        {   int result = 0;
            int sum = 0;
            int indexStart = 0;
            int indexEnd = 0;
            int tempStart = 0;
            for (int index = 0; index < a.Length; index++)
            {
                sum += a[index];
                if (sum > result)
                {
                    result = sum;
                    indexStart = tempStart;
                    indexEnd = index;
                }
                if (sum < 0)
                {
                    sum = 0;
                    tempStart = index + 1;
                }
            }
            return result;
        }

    }

    

}
