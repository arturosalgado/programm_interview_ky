using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            int []a = {-1 ,2, 3, -2};

            max1D(a);
            Console.ReadKey();
        }


        static int max1D(int[]a )
        {
            List<int> List = new List<int>();
            int temp = 0; 
            for (int i = 0; i < a.Length; i++)
            {
                if (temp + a[i] > temp)
                {
                    List.Add(temp+a[i]);
                }

            }


            foreach(var i in List)
            {
                Console.Write(i);
            }
            return 0; 

        }





    }
}
