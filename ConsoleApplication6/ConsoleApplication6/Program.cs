using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 23, 10, 20, 11 };
            print(arr);
            pancakeSort(arr,arr.Length);
            Console.WriteLine("Hello");
            print(arr);
            Console.ReadKey();
        }

        static void flip(int []arr, int i)
        {
            int temp, start = 0;
            Console.WriteLine("Before Flip");
            print(arr);
            while (start < i)
            {
                temp = arr[start];
                arr[start] = arr[i];
                arr[i] = temp;
                start++;
                i--;
            }
            Console.WriteLine("After flippign");
            print(arr);
            Console.WriteLine("");
        }

        static void pancakeSort(int []arr, int n)
        {
            // Start from the complete array and one by one reduce current size by one
            for (int curr_size = n; curr_size > 1; --curr_size)
            {
                // Find index of the maximum element in arr[0..curr_size-1]
                int mi = findMax(arr, curr_size);

                // Move the maximum element to end of current array if it's not
                // already at the end
                if (mi != curr_size - 1)
                {
                    // To move at the end, first move maximum number to beginning 
                    flip(arr, mi);
                    Console.ReadKey();
                    // Now move the maximum number to end by reversing current array
                    flip(arr, curr_size - 1);
                    Console.ReadKey();
                }
            }
        }


        static int findMax(int []arr, int n)
        {
           int mi, i;
           for (mi = 0, i = 0; i < n; ++i){
               Console.WriteLine("Mi = {0} and i={1}", mi,i);

               if (arr[i] > arr[mi])
               {
                   mi = i;
                   Console.WriteLine("Asignation...");
               }
           }

          Console.WriteLine("Mi to return= {0} and i={1}", mi,i);
            
           return mi;
        }
        static void print(int[] a)
        {

            foreach (int x in a)
            {
                Console.Write("[{0:D2}] ", x);

            }
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("|{0:D2}| ", i);
            }
            Console.WriteLine();

        }


    }
}
