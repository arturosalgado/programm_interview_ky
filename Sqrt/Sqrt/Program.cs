using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sqrt of 9 is {0}",sqrt(9));
            //Console.WriteLine("sqrt of 9 is {0}", sqrt(9));
            //Console.WriteLine("sqrt of 0.5 is {0}", sqrt(0.5));
            Console.ReadKey();

        }

        static double sqrt(double a)
        {
            if (a < 0) return -1;
            if (a == 0 || a == 1) return a;

            double precision = 0.01;

            double start = 0;
            double end = a;


            if (a < 1)
                end = 1;

            while (end - start > precision)
            {
                double mid = (start + end) / 2;
                Console.WriteLine("s+e/2 = mid is {0}",mid);
                double midSqr = mid * mid;
                Console.WriteLine("m*m = midSqr is {0}", midSqr);
                //Console.ReadKey();
                if (midSqr == a)
                    return mid; // we found the root 
                else if (midSqr < a)
                {
                    start = mid; //bigger half
                }
                else end = mid;// smaller half

            }

            return (start + end) / 2;

        }
    }
}
