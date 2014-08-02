using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionWithOutOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int candies = 30;
            int children = 4;
            Console.WriteLine(naive_division(candies,children));
            Console.WriteLine("");
            Console.WriteLine(opt_division(candies, children));

            Console.ReadKey();


        }

        static int naive_division(int divident, int divisor)
        {
            int quotient = 0;
            while (divident >= divisor)
            {
                divident = divident - divisor;
                quotient++;
            }

            return quotient;
        }

        static int opt_division(int divident, int divisor)
        {
            int quotient = 0;
            int current_base = 1;
            int current_divisor = divisor;
            while (divident >= divisor)
            {
                if (divident >= current_divisor)
                {
                    divident = divident - current_divisor;
                    quotient = quotient + current_base;
                    current_divisor *= 2;// make bigger chunks 
                    current_base *= 2;// reflect this jumps in the quotient
                }
                else {
                    current_divisor /= 2;
                    current_base /= 2;
                }

            }

            return quotient;
        }

    }
}
