using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] m= generate_matrix(4);
            print(m);
            rotate(m);
            print(m);

            Console.ReadKey();
        }

        static void rotate(int[,] m)
        {
            int n = m.GetLength(0) ;
            Console.WriteLine("n is {0}",n);
            int f =(int) Math.Floor(n / 2f);
            int c = (int)Math.Ceiling(n / 2f);
            Console.WriteLine("f{0} c{1}",f,c);
            for (int x = 0;  x< f; x++)
            {

                for (int y = 0; y < c; y++)
                {



                    Console.WriteLine("{0}{1} ",x,y);
                    Console.WriteLine("{0}{1} ", y, n-1-x);
                    Console.WriteLine("{0}{1} ", n  - 1-x, n-1-y);
                    Console.WriteLine("{0}{1} ", n  - 1-y,x);



                    int t = m[x, y];
                    m[x, y] = m[y, n  - 1-x];
                    m[y, n  - 1-x] = m[n - 1-x,n-1-y];
                    m[n  - 1-x, n - 1 - y] = m[n - 1-y, x];
                    m[n  - 1-y, x] = t;

                 
                    

                   

                   
                }
                
            }


        
        }


        static int[,] generate_matrix(int n)
        {
            if (n < 0) return null;

            int[,] m = new int[n,n];
            Random r = new Random();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = r.Next(1,10);
                }
               
            }


            return m;
        }
        static void print(int [,]m)
        { 
              //Console.WriteLine("m length {0}",m.Length); rows x cols
             
              //Console.WriteLine("m lendgth2 {0}", m.GetLength(0));// rows 
             // Console.WriteLine("m lendgth2 {0}", m.GetLength(1));// columns
           // int 

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(" {0} ",m[i,j]);
                }
                Console.WriteLine("");
            }



        }

    }
}
