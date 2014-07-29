using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHannoi
{
    class Program
    {
        static void Main(string[] args)
        {
            hannoi(8,'A','B','X',1);
            Console.WriteLine("---");
            

            Console.ReadKey();
        }

        

        static void hannoi(int n, char origin,char dest, char aux,int move)
        {
            Console.WriteLine("Move {0} ",move++);

            if (n == 0)
            {
                return;
            }
            else
            {
                hannoi(n - 1, origin, aux, dest,move++);
                Console.WriteLine("Move disc from {0} to {1} ", origin, dest);
                hannoi(n - 1, aux, dest, origin,move++);
            }

        
        }

    }
}
