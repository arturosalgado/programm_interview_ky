using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullyfyMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = generate_matrix(4);
            print(m);
            m= nullify(m);
            Console.ReadKey();
            print(m);
            Console.ReadKey();
        }


        static int[,] nullify(int[,] m)
        {
             int[,] aux = new int[m.GetLength(0),m.GetLength(1)];

             bool[] rows = new bool[m.GetLength(0)];
             bool[] cols = new bool[m.GetLength(1)];


             for (int i = 0; i < m.GetLength(0); i++)
             {
                 for (int j = 0; j < m.GetLength(1); j++)
                 {
                     if (m[i, j] == 0)
                     {
                         rows[i] = true;
                         cols[j] = true;
                     }
                 }

             }

             for (int i = 0; i < rows.GetLength(0); i++)
             {
                 if (rows[i] == true)
                 {
                     for (int k = 0; k < m.GetLength(1); k++)
                     { 
                        m[i,k]= 0; 
                     }
                 }
             }
             for (int i = 0; i < cols.GetLength(0); i++)
             {
                 if (cols[i] == true)
                 {
                     for (int k = 0; k < m.GetLength(0); k++)
                     {
                         m[k, i] = 0;
                     }
                 }

             }


            return m;


        }
        static int[,] generate_matrix(int n)
        {
            if (n < 0) return null;

            int[,] m = new int[n, n];
            Random r = new Random();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = r.Next(0, 10);
                }

            }


            return m;
        }

        static void print(int[,] m)
        {
            //Console.WriteLine("m length {0}",m.Length); rows x cols

            //Console.WriteLine("m lendgth2 {0}", m.GetLength(0));// rows 
            // Console.WriteLine("m lendgth2 {0}", m.GetLength(1));// columns
            // int 

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(" {0} ", m[i, j]);
                }
                Console.WriteLine("");
            }



        }
    }

   
}
